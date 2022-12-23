namespace life_assistant;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

public partial class Form1 : Form
{
    public List<String> shop = new List<String>() { "McDonald's","KFC","�@���M�d��","�p�U��", "�צױ�", "123����" , "�������״�", "�p�����K��", "�x�n�}����������", "���]���״�", "���d_�馡�d���B����", "���W��N", "�æN���״�", "�p�ۭ�����", "ı�Y����", "���B�ѩ�", "�E���Ω���", "�p�j�� ��@�~��", "�����p�Y", "�D��������", "��������", "�j��t���]", "�K�����]", "�ĤG�J ��N�N��", "�@�I�¥]", "�����үN�T���v", "�C������", "�~��������", "���A���窫�M��", "�b�H����", "��ҹŸq���׶�", };
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

    private void �s��M��ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Form2 form2 = new Form2(this);
        form2.ShowDialog();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}
