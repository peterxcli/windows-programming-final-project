using MaterialSkin.Controls;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace life_assistant.controller;

public partial class ToDoListMainFormMaterialSkin : MaterialForm
{
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    MaterialRadioButton[] things=new MaterialRadioButton[100];
    int ThingsCnt=0;
    string DataFilePath = "./Data/To-Do-List-Data.json";
    public ToDoListMainFormMaterialSkin()
    {
        InitializeComponent();
        materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(this);
        MaterialThemeManager materialThemeManager = new();
        materialThemeManager.setDefaultTheme(materialSkinManager);

        if (!Directory.Exists(Path.GetDirectoryName(DataFilePath)))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(DataFilePath));
        }
        for (int i = 0; i < 100; i++)
        {
            things[i]=new MaterialRadioButton();
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
            sr.Close();

            List<string> thingsL = JsonSerializer.Deserialize<List<string>>(thing_name);
            foreach(string item in thingsL)
            {
                things[ThingsCnt].Text = item;
                things[ThingsCnt].Visible = true;
                things[ThingsCnt].Visible = true;

                ThingsCnt++;
            }
            Update();
        }
    }

    void UpdateData()
    {
        List<string> thingsL= new List<string>();
        for (int i = 0; i < ThingsCnt; i++) thingsL.Add(things[i].Text);
        StreamWriter sw = new StreamWriter(DataFilePath);
        sw.WriteLine(JsonSerializer.Serialize(thingsL));
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
        MaterialRadioButton RadBtn=(MaterialRadioButton)sender;
        if (RadBtn.Checked == false) return;
        string target = RadBtn.Text;
        int TargetIndex = 0;
        while (things[TargetIndex].Text != target) TargetIndex++;
        things[TargetIndex].Checked = false;

        for (int i = TargetIndex; i + 1 < ThingsCnt; i++)
        {
            things[i].Text = things[i + 1].Text;
        }
        things[--ThingsCnt].Visible = false;

        UpdateData();
    }
}
