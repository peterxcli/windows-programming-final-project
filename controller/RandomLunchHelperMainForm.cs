using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using life_assistant.controller.spending_tracker;
using MaterialSkin.Controls;

namespace life_assistant.controller;

public partial class RandomLunchHelperMainForm : MaterialForm
{
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    public List<String> shop = new List<String>() { "McDonald's","KFC","一中刀削麵","小帽屋", "肉肉控", "123炒飯" , "億哥牛肉湯", "小蔡陽春麵", "台南開源社香雞排", "阿財牛肉湯", "飢丼_日式丼飯、炸物", "杉上鍋燒", "永吉牛肉湯", "菘芝香滷味", "覺丸拉麵", "牛伯麵店", "九湯屋拉麵", "小古巴 手作漢堡", "香香小吃", "胖媽媽炒飯", "皮嚓先生", "大醬川麵館", "添福麵館", "第二碗 鍋燒意麵", "一點刈包", "郭媽碳烤三明治", "七海魚皮", "繼光香香雞", "五鮮級鍋物專賣", "豚人拉麵", "後甲嘉義雞肉飯", };
    public RandomLunchHelperMainForm()
    {
        InitializeComponent();
        materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(this);
        MaterialThemeManager materialThemeManager = new();
        materialThemeManager.setDefaultTheme(materialSkinManager);
    }
    

    private void button1_MouseUp(object sender, MouseEventArgs e)
    {
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
