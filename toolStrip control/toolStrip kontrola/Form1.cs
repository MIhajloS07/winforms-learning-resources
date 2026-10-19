namespace toolStrip_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStrip tool = new ToolStrip();

            // Cut button
            ToolStripButton cut = new ToolStripButton();
            cut.Text = "Cut";
            cut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cut.ToolTipText = "Cut selected text";
            cut.Click += (s, e) =>
            {
                richTextBox1.Cut();
            };
            // Copy button
            ToolStripButton copy = new ToolStripButton();
            copy.Text = "Copy";
            copy.DisplayStyle= ToolStripItemDisplayStyle.Image;
            copy.ToolTipText = "Copy selected text";
            copy.Click += (s, e) =>
            {
                richTextBox1.Copy();
            };
            // Paste button
            ToolStripButton paste = new ToolStripButton();
            paste.Text = "Paste";
            paste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            paste.ToolTipText = "Paste copied text";
            paste.Click += (s, e) =>
            {
                richTextBox1.Paste();
            };
            // Help button
            ToolStripButton help = new ToolStripButton();
            help.Text = "Help";
            help.DisplayStyle = ToolStripItemDisplayStyle.Image;
            help.ToolTipText = "Help option";
            help.Click += (s, e) =>
            {
                MessageBox.Show(
                    "Pisi tekst u textbox, gore u toolstrip imas stavke pa koristi!",
                    "Help",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            };

            // Add items
            tool.Items.Add(cut);
            tool.Items.Add(copy);
            tool.Items.Add(paste);
            tool.Items.Add(help);
            // Add control to Form
            this.Controls.Add(tool);
        }
    }
}
