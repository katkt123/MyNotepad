using System.Drawing.Printing;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class Form1 : Form
    {
        private Font currentFont; // Đối tượng Font hiện tại
        private string currentFilePath = ""; // Đường dẫn tới tệp hiện tại (ban đầu là rỗng)
        private bool unsavedChanges = false; // Biến kiểm tra xem có thay đổi chưa được lưu

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newNotepad = new Form1(); // Tạo một cửa sổ Notepad mới
            newNotepad.Show(); // Hiển thị cửa sổ Notepad mới
        }

        private void statusBảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// phần của Kiệt
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                if (unsavedChanges == false)
                {
                    // Nếu có thay đổi chưa được lưu, hỏi người dùng có muốn lưu trước khi mở tệp mới không
                    DialogResult result = MessageBox.Show("Tệp hiện tại chưa được lưu. Bạn có muốn lưu trước khi mở tệp mới?", "Lưu trước khi mở", MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Yes)
                    {
                        // Lưu thay đổi
                        Save();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // Ngăn chặn mở tệp nếu chọn Cancel
                        return;
                    }

                }
            }
            Open();



        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }
        private void Open()
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName; // Lưu đường dẫn của tệp mở
                    unsavedChanges = false; // Đánh dấu rằng không có thay đổi chưa được lưu

                    // Đọc nội dung từ tệp và hiển thị trong richrichTextBox1
                    richTextBox1.Text = File.ReadAllText(currentFilePath);
                    unsavedChanges = true;
                    UpdateFormTitle(); // Cập nhật tiêu đề của Form1
                }
            }
        }
        private void Save()
        {
            // Kiểm tra xem đã có đường dẫn tệp hiện tại chưa
            if (string.IsNullOrEmpty(currentFilePath))
            {
                // Nếu chưa có đường dẫn, sử dụng hàm Save As để chọn đường dẫn và tên tệp
                SaveAs();
            }
            else
            {
                // Lưu nội dung vào tệp hiện tại
                File.WriteAllText(currentFilePath, richTextBox1.Text);
                //unsavedChanges = false; // Đánh dấu rằng không có thay đổi chưa được lưu
                UpdateFormTitle(); // Cập nhật tiêu đề của Form1
            }
        }

        private void SaveAs()
        {
            // Hiển thị hộp thoại "Save As" để chọn đường dẫn và tên tệp
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName; // Lưu đường dẫn vào biến currentFilePath
                    File.WriteAllText(currentFilePath, richTextBox1.Text); // Lưu nội dung vào tệp
                    //unsavedChanges = false; // Đánh dấu rằng không có thay đổi chưa được lưu
                    UpdateFormTitle(); // Cập nhật tiêu đề của Form1
                }
            }
        }
        private void UpdateFormTitle()
        {
            // Thiết lập tiêu đề của Form1 dựa trên tên tệp
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                string fileName = Path.GetFileNameWithoutExtension(currentFilePath);
                this.Text = fileName;
            }
            else
            {
                this.Text = "Untitled"; // Hoặc tiêu đề mặc định nếu không có tên tệp
            }
        }

        ///phan 2 cua Loc/
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }



        private void cutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }


        /// Phần của Khoa
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void undoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
            {
                Clipboard.SetText(richTextBox1.SelectedText);
                richTextBox1.SelectedText = string.Empty;
            }
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageSettings pageSettings = new PageSettings();

            // Gán đối tượng PageSettings cho PageSetupDialog
            pageSetupDialog1.PageSettings = pageSettings;

            // Hiển thị hộp thoại cài đặt trang
            pageSetupDialog1.ShowDialog();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 12, 10);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != null)
            {
                Clipboard.SetText(richTextBox1.SelectedText);
            }
        }

        private void pasteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                richTextBox1.SelectedText = Clipboard.GetText();
            }
        }

        private void deleteToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
            {
                richTextBox1.SelectedText = string.Empty;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                if (unsavedChanges == false)
                {
                    // Nếu có thay đổi chưa được lưu, hỏi người dùng có muốn lưu trước khi mở tệp mới không
                    DialogResult result = MessageBox.Show("Tệp hiện tại chưa được lưu. Bạn có muốn lưu trước khi mở tệp mới?", "Lưu File", MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Yes)
                    {
                        // Lưu thay đổi
                        Save();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // Ngăn chặn mở tệp nếu chọn Cancel
                        return;
                    }

                }
            }
            this.Close();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
                {
                    if (unsavedChanges == false)
                    {

                        DialogResult result = MessageBox.Show("Bạn chưa lưu file. Bạn có muốn lưu trước khi thoát?", "Lưu file", MessageBoxButtons.YesNoCancel);

                        if (result == DialogResult.Yes)
                        {
                            saveAsToolStripMenuItem_Click(sender, e);
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            e.Cancel = true; // Ngăn chặn việc thoát nếu chọn Cancel
                        }
                    }
                }
                
            
        }
    }
}