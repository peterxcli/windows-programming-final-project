using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using life_assistant.controller.random_lunch_helper;
using MaterialSkin.Controls;
using System.Text.Json;

namespace life_assistant.controller;

public partial class RandomLunchHelperMainForm : MaterialForm
{
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    public List<String> shop = new List<String>();

    public List<String> default_shop = new List<String>() { "McDonald's", "KFC", "?@???M?d??", "?p?U??", "?צױ?", "123????", "???????״?", "?p?????K??", "?x?n?}??????????", "???]???״?", "???d_?馡?d???B????", "???W???N", "?æN???״?", "?p?ۭ?????", "ı?Y????", "???B?ѩ?", "?E???Ω???", "?p?j?? ???@?~??", "?????p?Y", "?D????????", "????????", "?j???t???]", "?K?????]", "?ĤG?J ???N?N??", "?@?I?¥]", "?????үN?T???v", "?C??????", "?~????????", "???A???窫?M??", "?b?H????", "???ҹŸq???׶?", };

    string DataFilePath = "./Data/Random-Lunch-Helper.json";

    public RandomLunchHelperMainForm()
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

        if (!File.Exists(DataFilePath))
        {
            File.Create(DataFilePath).Dispose();
            return;
        }
        
        StreamReader sr = new StreamReader(DataFilePath);
        string shop_name = sr.ReadLine();
        sr.Close();
        
        if (shop_name==null)
        {
            shop = default_shop;
        }
        else
        {
            shop = JsonSerializer.Deserialize<List<string>>(shop_name);
        }
    }
    

    private void button1_MouseUp(object sender, MouseEventArgs e)
    {
        if (shop.Count() == 0)
        {
            MessageBox.Show("Please add Restaurant first!");
            return;
        }

        int cnt = 0;
        while (cnt++ < 50)
        {
            result.Text = shop[cnt % shop.Count()];

            var t = Task.Run(async delegate
            {
                await Task.Delay(50);
                return 42;
            });
            t.Wait();
        }
        Random R = new Random();
        result.Text = shop[R.Next(0,shop.Count())];
    }

    private void editListToolStripMenuItem_Click(object sender, EventArgs e)
    {
        EditLunchListForm form2 = new EditLunchListForm(this);
        form2.ShowDialog();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}
