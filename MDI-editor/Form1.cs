namespace MDI_editor
{
    public partial class Form1 : Form
    {
        int formindex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formindex = this.MdiChildren.Length;
            Form ChildForm = new Form(); //шинээр форм үүсгэх
            ChildForm.Name = "Child" + (formindex + 1).ToString(); //формын нэр зааж байна
            ChildForm.Text = "Child" + (formindex + 1).ToString(); //формын гарчиг зааж байна.
            ChildForm.MdiParent = this; //Эцэг цонхыг зааж байна.
            TextBox txtBox = new TextBox(); //текст бичих талбар үүсгэж байна
            txtBox.Dock = DockStyle.Fill; //форм дээр дүүргэж байна.
            txtBox.Multiline = true; // олон мөр текст бичих боломжтой болно.
            ChildForm.Controls.Add(txtBox); // хүү формын контролуудын массивт нэмж байна.
            ChildForm.Show(); // хүү формыг харагдуулж байна.
        }

        private void cascedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void virtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void horstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
