namespace life_assistant;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

public partial class Form1 : Form
{
    List<String> shop = new List<String>() { "McDonald's","KFC","¤@¤¤¤M«dÄÑ","¤p´U«Î", "¦×¦×±±", "123ª£¶º" };
    public Form1()
    {
        InitializeComponent();
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
}
