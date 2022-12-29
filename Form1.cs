namespace life_assistant;

public partial class Form1 : Form
{
    RadioButton[] things=new RadioButton[100];
    int ThingsCnt=0;
    public Form1()
    {
        InitializeComponent();
        for(int i = 0; i < 100; i++)
        {
            things[i]=new RadioButton();
            things[i].SetBounds(100,150+80*i,80, 70);
            things[i].AutoSize= true;
            things[i].Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold);
            things[i].Text = "test";
            things[i].Visible = false;
            things[i].CheckedChanged += radioButton_CheckedChanged;
            Controls.Add(things[i]);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string thing_name = textbar.Text;
        textbar.Text = "";
        if (thing_name == "")
        {
            MessageBox.Show("Can't be empty!");
            return;
        }

        things[ThingsCnt].Text = thing_name;
        things[ThingsCnt].Visible = true;

        ThingsCnt++;
        CntBar.Text = ThingsCnt.ToString();
    }

    private void textbar_KeyDown(object sender, KeyEventArgs e)
    {
        if(e.KeyCode==Keys.Enter)
        {
            button1_Click(sender, e);
            textbar.Focus();
        }
    }

    private void radioButton_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton RadBtn=(RadioButton)sender;
        if (RadBtn.Checked == false) return;
        String target = RadBtn.Text;
        int TargetIndex = 0;
        while (things[TargetIndex].Text != target) TargetIndex++;
        things[TargetIndex].Checked = false;

        for (int i = TargetIndex; i + 1 < ThingsCnt; i++)
        {
            things[i].Text = things[i + 1].Text;
        }
        things[--ThingsCnt].Visible = false;
        CntBar.Text = ThingsCnt.ToString();

    }

}
