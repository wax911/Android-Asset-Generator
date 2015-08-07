using System;
using System.Linq;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Generator;
using ThreadState = System.Threading.ThreadState;

namespace Resource_Generator
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private static Converter conv;
        private static IoAccess ioAccess;
        private static string[] originalNames , paths;
        private static Mode operationMode;
        private static int count;
        private static Image[] Images;
        private static int index;
        private Thread loaderAsync;
        #region readonly
        private static readonly Resolution[] res = { new Resolution() { Height = 72, Width = 72 }, 
                                                       new Resolution() { Height = 48, Width = 48 }, 
                                                       new Resolution() { Height = 96, Width = 96 }, 
                                                       new Resolution() { Height = 144, Width = 144 }, 
                                                       new Resolution() { Height = 192, Width = 192 } 
                                                   };
        private static readonly string destination = @"C:\Android Resource Generator\";
        private static readonly string format = ".png";
        private static readonly string message ="The name of your rename file is too short, the minimum is 3 characters. " +
                                                "Do you want to continue without renaming any of the images?";
        private static readonly Validate validator = new Validate();
        #endregion

        private void InitConmponents()
        {
            conv = new Converter();
            ioAccess = new IoAccess();
            loaderAsync = new Thread(LoadElements) { IsBackground = true };
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            lstImages.View = View.LargeIcon;
            lstImages.Dock = DockStyle.None;
        }

        private void lstImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRename.ReadOnly = lstImages.SelectedItems.Count < 0;
            if (lstImages.SelectedItems.Count <= 0) return;
                index = lstImages.SelectedIndices[0];
                txtRename.Text = originalNames[index];
        }

        private void prgConversion_Click(object sender, EventArgs e)
        {

        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var image = (Image[])e.Argument;
            for (int j = 0; j < count; j++)
            {
                if (Worker.CancellationPending)
                    break;
                for (int i = 0; i < res.Length; i++)
                {
                    ioAccess.SavePNG(conv.ResizeImage(image[j], res[i]), 100,txtWorkspace.Text, i, (originalNames[j] + format));
                    Worker_ProgressChanged(sender, new ProgressChangedEventArgs(((i + j) + 1), sender));
                }
            }
            Worker_RunWorkerCompleted(sender,new RunWorkerCompletedEventArgs(null,null,false));
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BeginInvoke((MethodInvoker)
                delegate
                {
                    prgConversion.Value = e.ProgressPercentage; 
                });
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BeginInvoke((MethodInvoker)
                delegate
                {
                    btnOpenFolder.Enabled = true;
                    btnBegin.Enabled = true;
                    btnCancel.Enabled = false;
                });
        }

        private void LoadElements()
        {
            var obj = new object();

            Monitor.TryEnter(obj);
            BeginInvoke((MethodInvoker)(() => lstImages.Clear()));
            
            var thumbs = new ImageList()
            {
                ColorDepth = ColorDepth.Depth16Bit
            };

            for (int i = 0; i < count; i++)
            {
                
                Images[i] = Thumb.ResizeImage((Bitmap)Image.FromFile(paths[i]), 80, 80, true);
                originalNames[i] = string.Format("img{0}", i);
                thumbs.ImageSize = new Size(Images[i].Width, Images[i].Height);
                thumbs.Images.Add(string.Format("{0}",i), Images[i]);
                int c = i;
                BeginInvoke(new Action(() =>
                {
                    lstImages.Items.Add(new ListViewItem(string.Format("{0}", originalNames[c]), c));
                    prgLoadingimgs.Value = (c + 1);
                }));

            }

            BeginInvoke((MethodInvoker) delegate
            {
                lstImages.LargeImageList = thumbs;
                lblCount.Text = string.Format("{0}", count);
                btnBegin.Enabled = true; 
            });
            Monitor.Exit(obj);
        }

        private void Single()
        {
            using (var opf = new OpenFileDialog())
            {
                opf.Filter = @"Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png)";
                switch (opf.ShowDialog())
                {
                    case DialogResult.OK:
                        count = 1;
                        Images = new Image[count];
                        txtDirectory.Text = opf.FileName;
                        paths = new [] {txtDirectory.Text};
                        originalNames = new [] {opf.SafeFileName};
                        prgLoadingimgs.Maximum = count;
                        prgConversion.Maximum = (res.Length);
                        loaderAsync.Start();
                        break;

                    default:
                        MessageBox.Show(string.Format("You didn't select any image file"), string.Format("No Selected File"), MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        break;
                }
            }
        }

        private void Multiple()
        {
            using (var fdl = new FolderBrowserDialog() )
            {
                switch (fdl.ShowDialog())
                {
                    case DialogResult.OK:
                        txtDirectory.Text = fdl.SelectedPath;
                        LoadDirecoryItems();
                        break;
                    
                    default:
                        MessageBox.Show(string.Format("You didn't select any folder"), string.Format("No Folder Selected"), MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        break;
                }
            }
        }

        private void LoadDirecoryItems()
        {
            paths = Directory.GetFiles(txtDirectory.Text,"*.*",SearchOption.TopDirectoryOnly).Where(x => x.EndsWith(".jpeg") || x.EndsWith(".jpg") || x.EndsWith(".png")).ToArray();
            count = paths.Length;

            if (count != 0)
            {
                prgConversion.Maximum = (res.Length + (count));
                prgLoadingimgs.Maximum = count;
                Images = new Image[count];
                originalNames = new string[count];
                loaderAsync.Start();
            }
            else
            {
                MessageBox.Show(string.Format("No images could be located in the selected directory. The image files need to be in either jpeg/jpg/png for folder broser, try single file browsing if the problem persists"),
                    string.Format("No Results"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (!HandlerOptions()) return;
            InitConmponents();
            switch (operationMode)
            {
                case Mode.Single:
                    Single();
                    break;
                case Mode.Multiple:
                    Multiple();
                    break;
            }
        }

        private bool HandlerOptions()
        {
            if (rdbMul.Checked || rdbSin.Checked) return true;
            notifyIcon.BalloonTipText = string.Format("A file option has to be selected, either a single file or multiple files");
            notifyIcon.ShowBalloonTip(500, "Operation Not Specified", notifyIcon.BalloonTipText, ToolTipIcon.Error);
            return false;
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(destination);
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (Worker.IsBusy)
            {
                MessageBox.Show(String.Format("Please wait for the application to finish current operations."), string.Format("Operation in progress"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            

            if (txtWorkspace.TextLength >= 3 && originalNames.Count(x=>x != string.Empty) > 0)
            {
                if (MessageBox.Show(message, string.Format("Rename files"), MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes) return;
                btnBegin.Enabled = false;
                btnOpenFolder.Enabled = false;
                btnCancel.Enabled = true;
                Worker.RunWorkerAsync(Images);
            }
            else
            {
                MessageBox.Show("The workspace field cannot be empty! The minimum length allowed is 3 letters",
                    string.Format("Field Length Short"), MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtWorkspace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validator.Validator(e.KeyChar.ToString(), RulesEx.numberandletters)) return;
            notifyIcon.BalloonTipText = string.Format("The character '{0}' is invalid and cannot be accepted. " +
                                                      "Only numbers and letters are allowed in the Workspace field",e.KeyChar);
            notifyIcon.ShowBalloonTip(800,"Invalid Character",notifyIcon.BalloonTipText,ToolTipIcon.Warning);
        }

        /// <summary>
        /// Configure the application to use file dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbSin_CheckedChanged(object sender, EventArgs e)
        {
            operationMode = Mode.Single;
        }

        /// <summary>
        /// Configure the application to use folder dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbMul_CheckedChanged(object sender, EventArgs e)
        {
            operationMode = Mode.Multiple;
        }

        private void txtRename_TextChanged(object sender, EventArgs e)
        {
            if (validator.Validator(txtRename.Text, RulesEx.numberandletters))
            {
                lblCharRename.Text = string.Format("{0}/15", txtRename.TextLength);
                originalNames[index] = txtRename.Text;
                return;
            }
            txtRename.Clear();
            lblCharRename.Text = string.Format("{0}/15",txtRename.TextLength);
        }

        private void txtWorkspace_TextChanged(object sender, EventArgs e)
        {
            if (validator.Validator(txtWorkspace.Text, RulesEx.numberandletters))
            {
                lblWorkspace.Text = string.Format("{0}/15", txtWorkspace.TextLength);
                return;
            }
            txtWorkspace.Clear();
            lblWorkspace.Text = string.Format("{0}/15", txtWorkspace.TextLength);
        }

        private void txtRename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validator.Validator(e.KeyChar.ToString(), RulesEx.numberandletters)) return;
            notifyIcon.BalloonTipText = string.Format("The character '{0}' is invalid and cannot be accepted. " +
                                                      "Only numbers and letters are allowed in the image renaming feild", e.KeyChar);
            notifyIcon.ShowBalloonTip(500, "Invalid Character", notifyIcon.BalloonTipText, ToolTipIcon.Warning);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainScreen_FormClosing(sender,new FormClosingEventArgs(CloseReason.UserClosing, false));
            Environment.Exit(0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(!Worker.IsBusy) return;
            Worker.CancelAsync();
            btnCancel.Enabled = false;
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.Visible = false;
            notifyIcon.Icon = null;
            if(Worker.IsBusy)
                Worker.CancelAsync();
            if (loaderAsync != null)
            {
                if (loaderAsync.ThreadState != ThreadState.Running) return;
                loaderAsync.Abort(e.CloseReason);
            }
        }
    }
}
