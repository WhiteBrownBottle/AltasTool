using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltasTool
{
    public partial class AltasTool : Form
    {
       AtlasFacade m_Facade = new AtlasFacade();
        private string m_file = null;
        public AltasTool()
        {
            InitializeComponent();
        }

        private void btnPrase_Click(object sender, EventArgs e)
        {
            if (m_file == null)
            {
                MessageBox.Show("请拖入一张图片进行处理");
                return;
            }
            bool isSuccess = true;
            try
            {
                //处理
                m_Facade.Process(m_file);
                //结果
                m_Facade.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show("解析失败" + exception.Message);
                return;
            }
            if (isSuccess)
            {
                MessageBox.Show("解析成功!");
            }
        }

        private void AltasTool_DragDrop(object sender, DragEventArgs e)
        {
            //判断
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            string file = files[0];
            if (!m_Facade.Valid(file))
            {
                MessageBox.Show("需要图片文件!");
                return;
            }
            m_file = file;

            picImage.Load(file);
        }

        private void btnPrase_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void AltasTool_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent((DataFormats.FileDrop)))
            {
                e.Effect = DragDropEffects.Move;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
