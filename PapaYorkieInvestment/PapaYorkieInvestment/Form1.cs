using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PapaYorkieInvestment
{
    public partial class YorkieMainForm : Form
    {
        private XmlDocument valuesXMLSettings;
        private XmlElement root;
        public string localUserPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        //public string _SettingsPATH = @"PapaYorkieLocalSettings\XMLForSettings.xml";

        Timer t = new Timer();

        //Timer to close down application
        private System.Windows.Forms.Timer timerCloseApp;
        private int counter = 10;

        public static string getResponseToSave = "";
        string _warnMessage = "";

        ToolTip toolTip = new ToolTip();
        public YorkieMainForm()
        {
            InitializeComponent();
            //Prevents users to enter any text. Set up in the visual part
            //cbSetClosingTime.DropDownStyle = ComboBoxStyle.DropDownList;

            DisableComponents();
            ReadXMLForSettings();

            //cbSetClosingTime.Text = "10";
            cbSetClosingTime.Enabled = false;
            //if (File.Exists(_SettingsPATH)) {
            //    ReadXMLForSettings();
            //}

            //timer interval
            t.Interval = 1000;  //in milliseconds

            t.Tick += new EventHandler(this.t_Tick);

            //start timer when form loads
            t.Start();  //this will use t_Tick() method
        }

        //timer eventhandler
        private void t_Tick(object sender, EventArgs e)
        {
            //counts current time
            DateTime time = DateTime.UtcNow;
            tsLabelTime.Text = time.ToLocalTime().ToString();
        }

        private void BtnMakeCall_Click(object sender, EventArgs e)
        {
            VerifyBeforeMakeCall();
        }
        //Make call
        public void MakeCall()
        {
            if (ckSaveWithMakeCall.Checked && txForFileName.Text.Trim() != "")
            {
                //MakeCall();
                btnMakeCall.Enabled = false;
                AsyncContext.Run(() => MainAsyncDoTransaction());
            }
            if (ckSaveWithMakeCall.Checked && txForFileName.Text.Trim() == "")
            {
                txMessageBox.Text = "Autosave content is enabled! You are missing your filename. Please type a filename!" + Environment.NewLine;
            }
            if (!ckSaveWithMakeCall.Checked && txForFileName.Text.Trim() == "")
            {
                txMessageBox.Text = "You are missing your filename. Click on 'EDIT SETTINGS' and assign a filename!" + Environment.NewLine;
            }
            if (!ckSaveWithMakeCall.Checked && btnEditSettings.Text == "SAVE SETTINGS" && txForFileName.Text.Trim() == "")
            {
                txMessageBox.Text = "You are missing your filename. Please type a filename!" + Environment.NewLine;
            }
            if (!ckSaveWithMakeCall.Checked && txForFileName.Text.Trim() != "")
            {
                txMessageBox.Text += "Autosave content is disabled! Showing content from server. To save content, click on 'SAVE XML'." + Environment.NewLine;
                //MakeCall();
                btnMakeCall.Enabled = false;
                AsyncContext.Run(() => MainAsyncDoTransaction());
            }
        }

        public void VerifyBeforeMakeCall()
        {
            //clear box
            txMessageBox.Text = "";

            //verify that all necessary strings are in place

            if (txtURL.Text.Trim() == "")
            {
                txMessageBox.Text = "You are missing a valid URL string! Click on 'EDIT SETTINGS' and save." + Environment.NewLine;
            }
            else
            if (txCKValue.Text.Trim() == "")
            {
                txMessageBox.Text = "You are missing a valid consumer key (CK) string! Click on 'EDIT SETTINGS' and save." + Environment.NewLine;
            }
            else
            if (txCSValue.Text.Trim() == "")
            {
                txMessageBox.Text = "You are missing a valid consumer secret (CS) string! Click on 'EDIT SETTINGS' and save." + Environment.NewLine;
            }
            else
            if (txTKValue.Text.Trim() == "")
            {
                txMessageBox.Text = "You are missing a valid token (TK) string! Click on 'EDIT SETTINGS' and save." + Environment.NewLine;
            }
            else
            if (txtURL.Text.Trim() == "")
            {
                txMessageBox.Text = "You are missing a valid token secret (TS) string! Click on 'EDIT SETTINGS' and save." + Environment.NewLine;
            }
            else
            if (txSavePath.Text.Trim() == "")
            {
                txMessageBox.Text = "You have not selected a location to save your XML file! Click on 'EDIT SETTINGS' and save." + Environment.NewLine;
            }
            else
            {
                MakeCall();
                //execute
                //btnMakeCall.Enabled = false;
                //AsyncContext.Run(() => MainAsyncDoTransaction());
            }
        }
        public async void MainAsyncDoTransaction()
        {
            // oauth application keys
            //var oauth_consumer_key = "*************";
            //var oauth_consumer_secret = "*************";
            //var oauth_token = "*************";
            //var oauth_token_secret = "*************";

            tsProgressBar.Value = 10;

            var oauth_consumer_key = txCKValue.Text.Trim();
            var oauth_consumer_secret = txCSValue.Text.Trim();
            var oauth_token = txTKValue.Text.Trim();
            var oauth_token_secret = txTSValue.Text.Trim();

            // oauth implementation details
            var oauth_version = "1.0";
            var oauth_signature_method = "HMAC-SHA1";

            // unique request details
            var oauth_nonce = Convert.ToBase64String(new ASCIIEncoding().GetBytes(DateTime.Now.Ticks.ToString()));
            var timeSpan = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var oauth_timestamp = Convert.ToInt64(timeSpan.TotalSeconds).ToString();
            //string symbols = "AAPL,QQQ,MSFT,VXX,GOOG";
            //string httpHeader = "%20HTTP%2F1.1";
            //string getQuery1 = "/v1/market/quotes.xml?symbols=" + symbols + " HTTP/1.0 ";
            //string getQuery1 = "/v1/market/accounts.xml";

            // message api details
            var status = "Attempting to contact the server..."; //?symbols=AAPL,QQQ,MSFT
                                                                //var resource_url = "https://stream.tradeking.com/v1/market/quotes.xml?symbols=UPS";

            /*It works individually - user needs to have the account number
             * https://api.tradeking.com/v1/accounts/******.xml
             * https://api.tradeking.com/v1/accounts/******.xml
             * https://api.tradeking.com/v1/market/ext/quotes.xml?symbols=aapl
             * https://api.tradeking.com/v1/market/ext/quotes.xml?symbols=ups
             * https://api.tradeking.com/v1/market/ext/quotes.xml?symbols=fdx
             * All accounts: https://api.tradeking.com/v1/accounts.xml
             */
            //var resource_url = "https://api.tradeking.com/v1/market/ext/quotes.xml?symbols=aapl,ups,fdx";
            tsProgressBar.Value += 10;
            var _resource_url = txtURL.Text.Trim();
            System.Threading.Thread.Sleep(1000);
            string _rootFolder = "";
            if (txtURLRoot.Text.Trim() != "")
            {
                _rootFolder = "/" + txtURLRoot.Text.Trim();
            }

            string _folder = "";
            if (txtURLFolder.Text.Trim() != "")
            {
                _folder = "/" + txtURLFolder.Text.Trim();
            }

            string _fileName = "";
            if (txtURLFileName.Text.Trim() != "")
            {
                _fileName = "/" + txtURLFileName.Text.Trim();
            }

            string _symbols = "";
            if (txtURLSymbols.Text.Trim() != "")
            {
                _symbols = "?symbols=" + txtURLSymbols.Text.Trim();
            }

            var resource_url = _resource_url + _rootFolder + _folder + _fileName + _symbols;

            //var resource_url = "https://api.tradeking.com/v1/accounts.xml";
            //var resource_url = "https://api.tradeking.com" + getQuery1;
            // create oauth signature
            var baseFormat = "OAuth oauth_consumer_key={0}&oauth_token={1}&oauth_signature_method={2}" +
                             "&oauth_timestamp={3}&oauth_nonce={4}&oauth_version={5}";
            //"&oauth_timestamp={3}&oauth_nonce={4}&oauth_version={5}&status={6}";

            var baseString = string.Format(baseFormat,
                                        oauth_consumer_key,
                                        oauth_token,
                                        oauth_signature_method,
                                        oauth_timestamp,
                                        oauth_nonce,
                                        oauth_version
                                        //oauth_version,
                                        //Uri.EscapeDataString(status)
                                        );

            baseString = string.Concat("POST&", Uri.EscapeDataString(resource_url), "&", Uri.EscapeDataString(baseString));
            tsProgressBar.Value += 10;
            var compositeKey = string.Concat(Uri.EscapeDataString(oauth_consumer_secret), "&", Uri.EscapeDataString(oauth_token_secret));

            string oauth_signature;

            using (HMACSHA1 hasher = new HMACSHA1(ASCIIEncoding.ASCII.GetBytes(compositeKey)))
            {
                oauth_signature = Convert.ToBase64String(hasher.ComputeHash(ASCIIEncoding.ASCII.GetBytes(baseString)));
            }

            // create the request header
            var headerFormat = "OAuth oauth_consumer_key={0}," +
                               "oauth_token={1}," +
                               "oauth_signature_method={2}," +
                               "oauth_signature={3}," +
                               "oauth_timestamp={4}," +
                               "oauth_nonce={5}," +
                               "oauth_version={6}";

            var authHeader = string.Format(headerFormat,
                                    Uri.EscapeDataString(oauth_consumer_key),
                                    Uri.EscapeDataString(oauth_token),
                                    Uri.EscapeDataString(oauth_signature_method),
                                    Uri.EscapeDataString(oauth_signature),
                                    Uri.EscapeDataString(oauth_timestamp),
                                    Uri.EscapeDataString(oauth_nonce),
                                    Uri.EscapeDataString(oauth_version)
                            );

            //make the request
            //var postBody = "status=" + Uri.EscapeDataString(status);
            var postBody = "Status = " + status;
            txMessageBox.Text = postBody + Environment.NewLine;
            if (ckSaveWithMakeCall.Checked)
            {
                _warnMessage = "FILE: Autosave 'SAVE WITH MAKE CALL' content is enabled!";
            }
            else
            {
                _warnMessage = "FILE: Autosave 'SAVE WITH MAKE CALL' content is disabled!";
            }
            txMessageBox.Text += _warnMessage + Environment.NewLine;
            txMessageBox.Text += "Your URL: " + resource_url + Environment.NewLine;
            //Console.WriteLine(postBody);

            ServicePointManager.Expect100Continue = false;
            tsProgressBar.Value += 10;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(resource_url);
                request.Headers.Add("Authorization", authHeader);

                //request.Host = "stream.tradeking.com";
                request.ContentType = "text/xml; encoding='utf-8'";
                request.Accept = "application/xml";
                //request.Method = "GET";
                request.KeepAlive = false;
                request.ProtocolVersion = HttpVersion.Version10;
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                tsProgressBar.Value += 10;
                txMessageBox.Text += "Waiting response from server..." + Environment.NewLine;
                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                {

                    //System.Threading.Thread.Sleep(500);
                    using (Stream stream = response.GetResponseStream())
                    {
                        System.Threading.Thread.Sleep(600);
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            tsProgressBar.Value += 10;
                            System.Threading.Thread.Sleep(500);

                            //get response from server - reformat some lines
                            string responseStr = (await reader.ReadToEndAsync()).Replace("<response id", "\n<response id").Replace("<elapsedtime>", "\n<elapsedtime>").Replace("<error>", "\n<error>").Replace("</response>", "\n</response>");
                            tsProgressBar.Value += 40;
                            System.Threading.Thread.Sleep(700);

                            status = "SUCCESS!";
                            txMessageBox.Text += "Status: " + status + Environment.NewLine;
                            getResponseToSave = responseStr;
                            txMessageBox.Text += responseStr;
                            btnMakeCall.Enabled = true;
                            reader.Dispose();
                            reader.Close();
                        }
                        stream.Dispose();
                        stream.Close();
                    }
                    response.Close();
                    tsProgressBar.Value = 0;

                    //save results if enabled
                    if (ckSaveWithMakeCall.Checked)
                    {
                        txMessageBox.Text += "Saving content as XML in your prefered location...";
                        System.Threading.Thread.Sleep(1200);
                        XMLSaveContent();
                    }
                    if (ckAutoClose.Checked)
                    {
                        System.Threading.Thread.Sleep(1200);
                        StartClosingTimer();
                    }
                }
            }
            catch (WebException webExc)
            {
                status = "FAILED!";
                if (webExc.Message.Contains("401"))
                {
                    txMessageBox.Text += "Status: " + status + Environment.NewLine;
                    txMessageBox.Text += "Error: No Success in server handshake! " + webExc.Message + " Please verify your keys and make sure they have the right characters or they are current. Make sure your 'consumer_key' and 'token' are correct. " + Environment.NewLine;
                    txMessageBox.Text += resource_url;
                    tsProgressBar.Value = 0;
                }
                else
                if (webExc.Message.Contains("404"))
                {
                    txMessageBox.Text += "Status: " + status + Environment.NewLine;
                    txMessageBox.Text += "Error: No Success in server handshake! " + webExc.Message + " Please verify that the URL is correct or if it is missing some character or if it has some extra character. " + Environment.NewLine;
                    txMessageBox.Text += resource_url;
                    tsProgressBar.Value = 0;
                }
                else
                {
                    txMessageBox.Text += "Status: " + status + Environment.NewLine;
                    txMessageBox.Text += webExc.Message + " " + Environment.NewLine;
                    txMessageBox.Text += resource_url;
                    tsProgressBar.Value = 0;
                }
                btnMakeCall.Enabled = true;
                tsProgressBar.Value = 0;
            }
            catch (Exception ex)
            {
                txMessageBox.Text += "Status: " + status + Environment.NewLine;
                txMessageBox.Text += ex.Message + Environment.NewLine;
                txMessageBox.Text += resource_url;
                btnMakeCall.Enabled = true;
                tsProgressBar.Value = 0;
            }
        }

        string svSettings = "SAVE SETTINGS";
        string edSettings = "EDIT SETTINGS";
        private void BtnEditSettings_Click(object sender, EventArgs e)
        {
            //btnEditSettings.Text = "SAVE SETTINGS";
            txMessageBox.Text = "";

            if (btnEditSettings.Text == "EDIT SETTINGS")
            {
                btnEditSettings.Text = svSettings;

                EnableComponents();
            }
            else
            {
                btnEditSettings.Text = edSettings;

                DisableComponents();

                if (txCKValue.Text.Trim() != "" || txCSValue.Text.Trim() != "" || txSavePath.Text.Trim() != "" || txTKValue.Text.Trim() != "" || txTSValue.Text.Trim() != "" || txtURL.Text.Trim() != "")
                {
                    CreateOrUpdateXMLSettings(false);
                }
                else
                {
                    txMessageBox.Text = "All fields are empty. Nothing has been saved!" + Environment.NewLine;
                }
            }
        }

        private void BtnClearMessageBox_Click(object sender, EventArgs e)
        {
            txMessageBox.Text = "";
        }

        public void DisableComponents()
        {
            txCKValue.Enabled = false;
            txCSValue.Enabled = false;
            txTKValue.Enabled = false;
            txTSValue.Enabled = false;

            btnClearTK.Enabled = false;
            btnClearTS.Enabled = false;
            btnClearAll.Enabled = false;
            btnClearCK.Enabled = false;
            btnClearCS.Enabled = false;

            txSavePath.Enabled = false;
            btnSavePath.Enabled = false;

            //ckFileName.Enabled = false;
            ckAutoClose.Enabled = false;
            ckSaveWithMakeCall.Enabled = false;
            txForFileName.Enabled = false;

            txCKValue.Enabled = false;
            ckAutoCallServer.Enabled = false;
            cbSetClosingTime.Enabled = false;
        }
        public void EnableComponents()
        {
            txCKValue.Enabled = true;
            txCSValue.Enabled = true;
            txTKValue.Enabled = true;
            txTSValue.Enabled = true;

            btnClearTK.Enabled = true;
            btnClearTS.Enabled = true;
            btnClearAll.Enabled = true;
            btnClearCK.Enabled = true;
            btnClearCS.Enabled = true;

            txSavePath.Enabled = true;
            btnSavePath.Enabled = true;
            //txCKValue.Enabled = false;

            //ckFileName.Enabled = true;
            ckAutoClose.Enabled = true;
            ckSaveWithMakeCall.Enabled = true;
            txForFileName.Enabled = true;

            ckAutoCallServer.Enabled = true;
            cbSetClosingTime.Enabled = true;

        }
        private void CkAutoClose_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableAutoClose();
        }
        public void EnableDisableAutoClose()
        {
            if (ckAutoClose.Checked)
            {
                txMessageBox.Text += "Function to AUTOCLOSE application is ENABLED." + Environment.NewLine;

                //cbSetClosingTime.Enabled = true;
            }
            else
            {
                txMessageBox.Text += "Function to AUTOCLOSE application is DISABLED." + Environment.NewLine;

                //cbSetClosingTime.Enabled = false;
            }
        }

        //Timer to close down application
        int selectedTime = 0;
        public void StartClosingTimer()
        {
            timerCloseApp = new System.Windows.Forms.Timer();
            timerCloseApp.Tick += new EventHandler(timerCloseApp_Tick);
            //txMessageBox.Text = "Saved content as XML. Shutting down Papa Yorkie in " + counter.ToString() + "s" + "! Good bye!" + Environment.NewLine;
            timerCloseApp.Interval = 1000; // 1 second
            timerCloseApp.Start();
            tsAutoCloseApp.Text = counter.ToString();

            if (int.TryParse(cbSetClosingTime.Text, out selectedTime))
            {
                counter = selectedTime;
            }
            //tsAutoCloseApp.Text = "Closing application in: " + counter.ToString() + "s";
        }

        private void timerCloseApp_Tick(object sender, EventArgs e)
        {
            counter--;
            txMessageBox.Text = "Saved content as XML. Shutting down Papa Yorkie in " + counter.ToString() + "s" + "! Good bye!" + Environment.NewLine;
            tsAutoCloseApp.Text = "Closing Papa Yorkie in: " + counter.ToString() + "s";
            if (counter == 0)
            {
                timerCloseApp.Stop();
                Close();
            }
        }
        private void BtnClearURL_Click(object sender, EventArgs e)
        {
            txtURL.Text = "";
            txtURLFileName.Text = "";
            txtURLFolder.Text = "";
            txtURLRoot.Text = "";
            txtURLSymbols.Text = "";
        }

        private void BtnClearCK_Click(object sender, EventArgs e)
        {
            txCKValue.Text = "";
        }

        private void BtnClearCS_Click(object sender, EventArgs e)
        {
            txCSValue.Text = "";
        }

        private void BtnClearTK_Click(object sender, EventArgs e)
        {
            txTKValue.Text = "";
        }

        private void BtnClearTS_Click(object sender, EventArgs e)
        {
            txTSValue.Text = "";
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            txtURL.Text = "";
            txtURLFileName.Text = "";
            txtURLFolder.Text = "";
            txtURLRoot.Text = "";
            txtURLSymbols.Text = "";
            txCKValue.Text = "";
            txCSValue.Text = "";
            txTKValue.Text = "";
            txTSValue.Text = "";
        }

        private void BtnSavePath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    txSavePath.Text = fbd.SelectedPath;
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Close application
            Close();
        }

        private void CreateOrUpdateXMLSettings(bool isCorrupted)
        {
            string _SettingsPATH = localUserPath + "\\";

            try
            {
                //if (!Directory.Exists(@"PapaYorkieLocalSettings\"))
                //{
                Directory.CreateDirectory(_SettingsPATH + @"\PapaYorkieLocalSettings\");
                //}
                //else
                //{
                XmlTextWriter writer = new XmlTextWriter(_SettingsPATH + @"\PapaYorkieLocalSettings\XMLForSettings.xml", System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("ApplicationSettings");

                writer.WriteStartElement("LocalConfiguration");

                //OAuth settings
                writer.WriteStartElement("oauth_consumer_key");
                writer.WriteString(txCKValue.Text.Trim());
                writer.WriteEndElement();

                writer.WriteStartElement("oauth_consumer_secret");
                writer.WriteString(txCSValue.Text.Trim());
                writer.WriteEndElement();

                writer.WriteStartElement("oauth_token");
                writer.WriteString(txTKValue.Text.Trim());
                writer.WriteEndElement();

                writer.WriteStartElement("oauth_token_secret");
                writer.WriteString(txTSValue.Text.Trim());
                writer.WriteEndElement();

                //End OAuth settings

                //URL settings
                writer.WriteStartElement("MainURL");
                writer.WriteString(txtURL.Text.Trim());
                writer.WriteEndElement();

                writer.WriteStartElement("URLRoot");
                writer.WriteString(txtURLRoot.Text.Trim());
                writer.WriteEndElement();

                writer.WriteStartElement("URLFolder");
                writer.WriteString(txtURLFolder.Text.Trim());
                writer.WriteEndElement();

                writer.WriteStartElement("URLFileName");
                writer.WriteString(txtURLFileName.Text.Trim());
                writer.WriteEndElement();

                writer.WriteStartElement("URLSymbols");
                writer.WriteString(txtURLSymbols.Text.Trim());
                writer.WriteEndElement();

                //End URL settings

                //Save location settings
                writer.WriteStartElement("SaveFilePath");
                writer.WriteString(txSavePath.Text.Trim());
                writer.WriteEndElement();

                //Save FILE NAME
                writer.WriteStartElement("SaveFileName");
                writer.WriteString(txForFileName.Text.Trim());
                writer.WriteEndElement();

                //Save autosave file
                writer.WriteStartElement("SaveFileWithMakeCall");
                if (ckSaveWithMakeCall.Checked)
                {
                    writer.WriteString("YES");                   
                }
                else
                {
                    writer.WriteString("NO");
                }
                writer.WriteEndElement();

                //save autoclose setting 
                writer.WriteStartElement("AutoCloseApplication");
                if (ckAutoClose.Checked)
                {
                    writer.WriteString("YES");
                }
                else
                {
                    writer.WriteString("NO");
                }
                writer.WriteEndElement();

                //SAVE TIME TO CLOSE
                writer.WriteStartElement("SetAutoCloseTime");
                writer.WriteString(cbSetClosingTime.Text.Trim());
                writer.WriteEndElement();

                //autoCall on launch
                writer.WriteStartElement("AutoCallOnLaunch");
                if (ckAutoCallServer.Checked)
                {
                    writer.WriteString("YES");
                }
                else
                {
                    writer.WriteString("NO");
                }
                writer.WriteEndElement();

                //writer.WriteEndElement();

                //all done
                writer.Close();

                txMessageBox.Text = "Your information has been saved!" + Environment.NewLine;

                if (isCorrupted)
                {
                    txMessageBox.Text = "The application settings were corrupted. An empty configuration file template was created. You will need to add new settings." + Environment.NewLine;
                }
                //MessageBox.Show("XML File created ! ");
                //}
            }
            catch (Exception exc)
            {
                txMessageBox.Text = exc.ToString();
            }
        }
        public void ReadXMLToReloadSettings()
        {
            //string _SettingsPATH = @"PapaYorkieLocalSettings\XMLForSettings.xml";

            string _SettingsPATH = localUserPath + "\\" + @"PapaYorkieLocalSettings\XMLForSettings.xml";
            try
            {
                if (!File.Exists(_SettingsPATH))
                {
                    //CreateOrUpdateXMLSettings();
                    txMessageBox.Text += "There are no settings available. Click on 'EDIT SETTINGS' and save." + Environment.NewLine;
                }
                else
                {
                    valuesXMLSettings = new XmlDocument();
                    valuesXMLSettings.Load(_SettingsPATH);
                    root = valuesXMLSettings.DocumentElement;

                    string _val1 = root.GetElementsByTagName("oauth_consumer_key")[0].InnerText;
                    string _val2 = root.GetElementsByTagName("oauth_consumer_secret")[0].InnerText;
                    string _val3 = root.GetElementsByTagName("oauth_token")[0].InnerText;
                    string _val4 = root.GetElementsByTagName("oauth_token_secret")[0].InnerText;
                    string _val5 = root.GetElementsByTagName("MainURL")[0].InnerText;
                    string _val6 = root.GetElementsByTagName("SaveFilePath")[0].InnerText;
                    string _val7 = root.GetElementsByTagName("SaveFileName")[0].InnerText;
                    string _val8 = root.GetElementsByTagName("SaveFileWithMakeCall")[0].InnerText;
                    string _val9 = root.GetElementsByTagName("AutoCloseApplication")[0].InnerText;
                    string _val11 = root.GetElementsByTagName("AutoCallOnLaunch")[0].InnerText;
                    string _val10 = root.GetElementsByTagName("SetAutoCloseTime")[0].InnerText;

                    if (_val1 == "" && _val2 == "" && _val3 == "" && _val4 == "" && _val5 == "" && _val6 == "")
                    {
                        txMessageBox.Text = "Please add settings to save. Reload setting function is empty." + Environment.NewLine;
                    }
                    else
                    if (_val1 != "" || _val2 != "" || _val3 != "" || _val4 != "" || _val5 != "" || _val6 != "")
                    {
                        txMessageBox.Text = "Settings available loaded." + Environment.NewLine;
                        txCKValue.Text = root.GetElementsByTagName("oauth_consumer_key")[0].InnerText;
                        txCSValue.Text = root.GetElementsByTagName("oauth_consumer_secret")[0].InnerText;
                        txTKValue.Text = root.GetElementsByTagName("oauth_token")[0].InnerText;

                        txTSValue.Text = root.GetElementsByTagName("oauth_token_secret")[0].InnerText;
                        txtURL.Text = root.GetElementsByTagName("MainURL")[0].InnerText;
                        txtURLFileName.Text = root.GetElementsByTagName("URLFileName")[0].InnerText;

                        txtURLFolder.Text = root.GetElementsByTagName("URLFolder")[0].InnerText;
                        txtURLRoot.Text = root.GetElementsByTagName("URLRoot")[0].InnerText;
                        txtURLSymbols.Text = root.GetElementsByTagName("URLSymbols")[0].InnerText;
                        txForFileName.Text = root.GetElementsByTagName("SaveFileName")[0].InnerText;
                        txSavePath.Text = root.GetElementsByTagName("SaveFilePath")[0].InnerText;

                        int n;
                        bool isNumeric = int.TryParse(_val10, out n);

                        if (!isNumeric)
                        {
                            cbSetClosingTime.Text = "10"; //default
                        }
                        else
                        {
                            cbSetClosingTime.Text = root.GetElementsByTagName("SetAutoCloseTime")[0].InnerText;
                        }

                        if (_val8 != null)
                        {
                            if (_val8 == "YES")
                            {
                                ckSaveWithMakeCall.Checked = true;
                                tsAutoSave.Text = "Autosave enabled: Yes";
                            }
                            else
                            {
                                ckSaveWithMakeCall.Checked = false;
                                tsAutoSave.Text = "Autosave enabled: No";
                            }
                        }
                        if (_val9 != null)
                        {
                            if (_val9 == "YES")
                            {
                                ckAutoClose.Checked = true;
                                tsAutoCloseEnabled.Text = "Autoclose enabled: Yes";
                            }
                            else
                            {
                                ckAutoClose.Checked = false;
                                tsAutoCloseEnabled.Text = "Autoclose enabled: No";
                            }
                        }
                        if (_val11 != null)
                        {
                            if (_val11 == "YES")
                            {
                                ckAutoCallServer.Checked = true;
                                tsAutoCallServer.Text = "Autocall server enabled: Yes";
                            }
                            else
                            {
                                ckAutoCallServer.Checked = false;
                                tsAutoCallServer.Text = "Autocall server enabled: No";
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                if (exc.ToString().Contains("NullReferenceException"))
                {
                    CreateOrUpdateXMLSettings(true);
                }
                else
                {
                    txMessageBox.Text = exc.ToString();
                }
            }
        }
        public void ReadXMLForSettings()
        {
            //string _SettingsPATH = @"PapaYorkieLocalSettings\XMLForSettings.xml";

            string _SettingsPATH = localUserPath + "\\" + @"PapaYorkieLocalSettings\XMLForSettings.xml";
            try
            {
                if (!File.Exists(_SettingsPATH))
                {
                    //CreateOrUpdateXMLSettings();
                    txMessageBox.Text += "There are no settings available. Click on 'EDIT SETTINGS' and save." + Environment.NewLine;
                }
                else
                {
                    valuesXMLSettings = new XmlDocument();
                    valuesXMLSettings.Load(_SettingsPATH);
                    root = valuesXMLSettings.DocumentElement;

                    string _val1 = root.GetElementsByTagName("oauth_consumer_key")[0].InnerText;
                    string _val2 = root.GetElementsByTagName("oauth_consumer_secret")[0].InnerText;
                    string _val3 = root.GetElementsByTagName("oauth_token")[0].InnerText;
                    string _val4 = root.GetElementsByTagName("oauth_token_secret")[0].InnerText;
                    string _val5 = root.GetElementsByTagName("MainURL")[0].InnerText;
                    string _val6 = root.GetElementsByTagName("SaveFilePath")[0].InnerText;
                    string _val7 = root.GetElementsByTagName("SaveFileName")[0].InnerText;
                    string _val8 = root.GetElementsByTagName("SaveFileWithMakeCall")[0].InnerText;
                    string _val9 = root.GetElementsByTagName("AutoCloseApplication")[0].InnerText;
                    string _val11 = root.GetElementsByTagName("AutoCallOnLaunch")[0].InnerText;
                    string _val10 = root.GetElementsByTagName("SetAutoCloseTime")[0].InnerText;

                    if (_val1 == "" && _val2 == "" && _val3 == "" && _val4 == "" && _val5 == "" && _val6 == "")
                    {
                        txMessageBox.Text = "Please add settings to save. Reload setting function is empty." + Environment.NewLine;
                    }
                    else
                    if (_val1 != "" || _val2 != "" || _val3 != "" || _val4 != "" || _val5 != "" || _val6 != "")
                    {
                        txMessageBox.Text = "Settings available loaded." + Environment.NewLine;
                        txCKValue.Text = root.GetElementsByTagName("oauth_consumer_key")[0].InnerText;
                        txCSValue.Text = root.GetElementsByTagName("oauth_consumer_secret")[0].InnerText;
                        txTKValue.Text = root.GetElementsByTagName("oauth_token")[0].InnerText;

                        txTSValue.Text = root.GetElementsByTagName("oauth_token_secret")[0].InnerText;
                        txtURL.Text = root.GetElementsByTagName("MainURL")[0].InnerText;
                        txtURLFileName.Text = root.GetElementsByTagName("URLFileName")[0].InnerText;

                        txtURLFolder.Text = root.GetElementsByTagName("URLFolder")[0].InnerText;
                        txtURLRoot.Text = root.GetElementsByTagName("URLRoot")[0].InnerText;
                        txtURLSymbols.Text = root.GetElementsByTagName("URLSymbols")[0].InnerText;
                        txForFileName.Text = root.GetElementsByTagName("SaveFileName")[0].InnerText;
                        txSavePath.Text = root.GetElementsByTagName("SaveFilePath")[0].InnerText;

                        int n;
                        bool isNumeric = int.TryParse(_val10, out n);

                        if (!isNumeric)
                        {
                            cbSetClosingTime.Text = "10"; //default
                        }
                        else
                        {
                            cbSetClosingTime.Text = root.GetElementsByTagName("SetAutoCloseTime")[0].InnerText;
                        }

                        if (_val8 != null)
                        {
                            if (_val8 == "YES")
                            {
                                ckSaveWithMakeCall.Checked = true;
                                tsAutoSave.Text = "Autosave enabled: Yes";
                            }
                            else
                            {
                                ckSaveWithMakeCall.Checked = false;
                                tsAutoSave.Text = "Autosave enabled: No";
                            }
                        }
                        if (_val9 != null) {
                            if (_val9 == "YES")
                            {
                                ckAutoClose.Checked = true;
                                tsAutoCloseEnabled.Text = "Autoclose enabled: Yes";
                            }
                            else
                            {
                                ckAutoClose.Checked = false;
                                tsAutoCloseEnabled.Text = "Autoclose enabled: No";
                            }
                        }
                        if (_val11 != null)
                        {
                            if (_val11 == "YES")
                            {
                                ckAutoCallServer.Checked = true;
                                tsAutoCallServer.Text = "Autocall server enabled: Yes";
                            }
                            else
                            {
                                ckAutoCallServer.Checked = false;
                                tsAutoCallServer.Text = "Autocall server enabled: No";
                            }
                        }
                    }
                }

                //call server on launch
                if (ckAutoCallServer.Checked)
                {
                    //VerifyBeforeMakeCall();
                    StartCallOnLaunchTimer();
                }
            }
            catch (Exception exc)
            {
                if (exc.ToString().Contains("NullReferenceException"))
                {
                    CreateOrUpdateXMLSettings(true);
                }
                else
                {
                    txMessageBox.Text = exc.ToString();
                }
            }
        }

        //Timer to execute and close application after data has been saved
        private System.Windows.Forms.Timer timerExecuteOnCall;
        private int ctrExecute = 10;

        //Timer to close down application
        public void StartCallOnLaunchTimer()
        {
            timerExecuteOnCall = new System.Windows.Forms.Timer();
            timerExecuteOnCall.Tick += new EventHandler(timerExecuteOnCall_Tick);

            if (ckAutoClose.Checked) {
                txMessageBox.Text = "Papa Yorkie is calling the server... The application will close after a response is received and saved." + Environment.NewLine;
            }
            else
            {
                txMessageBox.Text = "Papa Yorkie is calling the server. The XML response will be saved." + Environment.NewLine;
            }

            timerExecuteOnCall.Interval = 1000; // 1 second
            timerExecuteOnCall.Start();
            //tsAutoCloseApp.Text = counter.ToString();

            //tsAutoCloseApp.Text = "Closing application in: " + counter.ToString() + "s";
        }
        private void timerExecuteOnCall_Tick(object sender, EventArgs e)
        {
            ctrExecute--;
            if (ctrExecute == 0)
            {
                timerExecuteOnCall.Stop();
                //call server on launch
                if (ckAutoCallServer.Checked)
                {
                    VerifyBeforeMakeCall();
                }
            }
        }

        private void btnReloadSettings_Click(object sender, EventArgs e)
        {
            try
            {
                ReadXMLToReloadSettings();
            }
            catch (Exception)
            {
                txMessageBox.Text = "There are no settings available. Click on 'EDIT SETTINGS' and save." + Environment.NewLine;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSaveXML_Click(object sender, EventArgs e)
        {
            XMLSaveContent();
        }

        public void XMLSaveContent()
        {
            string _SaveContentPath = "";

            if (getResponseToSave == "")
            {
                txMessageBox.Text = "There is nothing to save. Click on 'MAKE CALL'." + Environment.NewLine;
            }
            else
            {
                if (txForFileName.Text.Trim() == "")
                {
                    txMessageBox.Text = "You are missing to assign a filename. Please add a filename!" + Environment.NewLine;
                }
                else
                {
                    if (txSavePath.Text.Trim() != "")
                    {
                        tsProgressBar.Value += 10;
                        System.Threading.Thread.Sleep(1000);
                        //string fileName = @"AllyInvest_" + RandomStringToken() + ".xml";
                        string fileName = txForFileName.Text.Trim() + ".xml";

                        _SaveContentPath = txSavePath.Text + "\\" + fileName;
                        // This text is added only once to the file.
                        try
                        {
                            //if (!File.Exists(_SaveContentPath))
                            //either exists or not, create or overwrite
                            if (!File.Exists(_SaveContentPath) || File.Exists(_SaveContentPath))
                            {
                                // Create a file to write to.
                                using (StreamWriter sw = File.CreateText(_SaveContentPath))
                                {
                                    tsProgressBar.Value += 10;
                                    txMessageBox.Text = "";
                                    sw.WriteLine(getResponseToSave);
                                    System.Threading.Thread.Sleep(1000);
                                    tsProgressBar.Value += 80;
                                    txMessageBox.Text = "Your XML file '" + fileName + "' has been saved in your prefered location: " + txSavePath.Text.Trim() + Environment.NewLine;

                                    txMessageBox.Text += getResponseToSave + Environment.NewLine;
                                    tsProgressBar.Value = 0;
                                }
                            }
                        }
                        catch (Exception exc)
                        {
                            txMessageBox.Text = "Error: " + exc;
                            tsProgressBar.Value = 0;
                        }
                    }
                    else
                    {
                        txMessageBox.Text = "You have not selected a path/folder to save your XML file. Click on 'EDIT SETTINGS' and select a path." + Environment.NewLine;
                        tsProgressBar.Value = 0;
                    }
                }
            }
        }
        public string RandomStringToken()
        {
            String hourMinute;
            hourMinute = DateTime.Now.ToString("HH_mm");
            string finalStringToken = "";
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[8];
            var random = new Random();
            try
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }
                finalStringToken = new String(stringChars) + hourMinute;
            }
            catch (Exception exc)
            {
                txMessageBox.Text = exc.ToString();
            }
            return finalStringToken;
        }

        private void HowToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am still working on this!", "HELP");
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am still working on this!", "ABOUT");
        }

        private void CkSaveWithMakeCall_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSaveWithMakeCall.Checked)
            {
                txMessageBox.Text += "Function to 'Save with MAKE CALL' is ENABLED." + Environment.NewLine;
            }
            else
            {
                txMessageBox.Text += "Function to 'Save with MAKE CALL' is DISABLED." + Environment.NewLine;
            }
        }

        private void TxtURL_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Enter a valid URL (example: https://api.tradeking.com)", txtURL);
        }

        private void TxtURLRoot_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Enter a valid parameter", txtURLRoot);
        }

        private void TxtURLFolder_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Enter a valid parameter", txtURLFolder);
        }

        private void TxtURLFileName_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Enter a valid parameter", txtURLFileName);
        }

        private void TxtURLSymbols_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Enter a valid parameter", txtURLSymbols);
        }

        private void TxCKValue_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Enter a valid consumer key value", txCKValue);
        }

        private void TxCSValue_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Enter a valid consumer secret value", txCSValue);
        }

        private void TxTKValue_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Enter a valid token value", txTKValue);
        }

        private void TxSavePath_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Click on 'Select Path' to select a folder to save your file", txSavePath);
        }

        private void TxTSValue_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Enter a valid token secret value", txTSValue);
        }

        private void TxForFileName_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Enter a valid filename", txForFileName);
        }

        private void CkSaveWithMakeCall_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Application will save file with MAKE CALL", ckSaveWithMakeCall);
        }

        private void CkAutoClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Application will auto close after call", ckAutoClose);
        }

        private void CkAutoCallServer_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Application will MAKE CALL next time is launched", ckAutoCallServer);
        }

        private void CbSetClosingTime_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Select closing time (in seconds)", cbSetClosingTime);
        }

        private void CkAutoCallServer_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAutoCallServer.Checked)
            {
                txMessageBox.Text += "Function to AUTO CALL SERVER ON LAUNCH is ENABLED." + Environment.NewLine;
            }
            else
            {
                txMessageBox.Text += "Function to AUTO CALL SERVER ON LAUNCH is DISABLED." + Environment.NewLine;
            }
        }
    }
}
