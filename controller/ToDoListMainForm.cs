using MaterialSkin.Controls;

namespace life_assistant.controller;

public partial class ToDoListMainForm : Form
{
    RadioButton[] things=new RadioButton[100];
    int ThingsCnt=0;
    string DataFilePath = "./Data/To-Do-List.json";
    public ToDoListMainForm()
    {
        InitializeComponent();
        

        if (!Directory.Exists(Path.GetDirectoryName(DataFilePath)))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(DataFilePath));
        }
        for (int i = 0; i < 100; i++)
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
        if(File.Exists(DataFilePath)) {
            StreamReader sr = new StreamReader(DataFilePath);

            string thing_name = sr.ReadLine();
            while (thing_name != null)
            {
                things[ThingsCnt].Text = thing_name;
                things[ThingsCnt].Visible = true;

                ThingsCnt++;
                CntBar.Text = ThingsCnt.ToString();
                thing_name = sr.ReadLine();
            }
            sr.Close();
        }
    }

    void UpdateData()
    {
        StreamWriter sw = new StreamWriter(DataFilePath);
        for (int i = 0; i < ThingsCnt; i++)
        {
            sw.WriteLine(things[i].Text);
        }
        sw.Close();
    }

    private void insert(object sender, EventArgs e)
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

        UpdateData();
    }

    private void textbar_KeyDown(object sender, KeyEventArgs e)
    {
        if(e.KeyCode==Keys.Enter)
        {
            insert(sender, e);
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

        UpdateData();
    }

    private void ToDoListMainForm_Load(object sender, EventArgs e)
    {

    }
}
