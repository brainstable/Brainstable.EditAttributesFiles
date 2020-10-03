using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Brainstable.EditAttributesFiles
{
    public partial class MainForm : Form
    {
        FileInfo fileInfo;
        string pathFile = String.Empty;
        long sizeFile = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_Change_Click(object sender, EventArgs e)
        {
            fileInfo.CreationTime = new DateTime(dtp_Created.Value.Year,
                dtp_Created.Value.Month,
                dtp_Created.Value.Day,
                fileInfo.CreationTime.Hour,
                fileInfo.CreationTime.Minute,
                fileInfo.CreationTime.Second,
                fileInfo.CreationTime.Millisecond);
            fileInfo.LastWriteTime = new DateTime(dtp_Changed.Value.Year,
                dtp_Changed.Value.Month,
                dtp_Changed.Value.Day,
                fileInfo.LastWriteTime.Hour,
                fileInfo.LastWriteTime.Minute,
                fileInfo.LastWriteTime.Second,
                fileInfo.LastWriteTime.Millisecond);
            fileInfo.LastAccessTime = fileInfo.LastWriteTime;


            lbl_Created.Text = $"{fileInfo.CreationTime.ToLongDateString()}, {fileInfo.CreationTime.ToLongTimeString()}";
            lbl_Changed.Text = $"{fileInfo.LastWriteTime.ToLongDateString()}, {fileInfo.LastWriteTime.ToLongTimeString()}";
            lbl_Opened.Text = $"{fileInfo.LastAccessTime.ToLongDateString()}, {fileInfo.LastAccessTime.ToLongTimeString()}";
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_LoadFile_Click(object sender, EventArgs e)
        {
            ofd_LoadFile = new OpenFileDialog();
            if (ofd_LoadFile.ShowDialog() == DialogResult.OK)
            {

                pathFile = ofd_LoadFile.FileName;
                fileInfo = new FileInfo(pathFile);
                sizeFile = fileInfo.Length;
                dtp_Created.Value = fileInfo.CreationTime;
                dtp_Changed.Value = fileInfo.LastWriteTime;

                lbl_NameFile.Text = Path.GetFileName(pathFile);
                lbl_PathFile.Text = ofd_LoadFile.FileName;
                lbl_ExtFile.Text = Path.GetExtension(pathFile);

                StringBuilder sb = new StringBuilder();
                if (sizeFile > 1024*1024)
                {
                    sb.Append($"{(double)(sizeFile / (1024m * 1024m)):f2} Mb ");
                }
                else
                {
                    sb.Append($"{(double)(sizeFile / 1024m):f1} Kb ");
                }
                sb.Append($"({sizeFile} byte)");
                lbl_SizeFile.Text = sb.ToString();

                lbl_Created.Text = $"{fileInfo.CreationTime.ToLongDateString()}, {fileInfo.CreationTime.ToLongTimeString()}"; 
                lbl_Changed.Text = $"{fileInfo.LastWriteTime.ToLongDateString()}, {fileInfo.LastWriteTime.ToLongTimeString()}";
                lbl_Opened.Text = $"{fileInfo.LastAccessTime.ToLongDateString()}, {fileInfo.LastAccessTime.ToLongTimeString()}";
            }
        }





        private void AllClear()
        {
            lbl_NameFile.Text = "...";
            lbl_PathFile.Text = "...";
            lbl_ExtFile.Text = "...";
            lbl_SizeFile.Text = "...";
            fileInfo = null;
            pathFile = "";
            sizeFile = 0;
            lbl_Changed.Text = lbl_Created.Text = lbl_Opened.Text = "...";
            dtp_Changed.Value = dtp_Created.Value = DateTime.Now;

        }
    }
}
