namespace life_assistant;

public partial class Form1 : Form
{
    RadioButton[] things=new RadioButton[10];
    public Form1()
    {
        InitializeComponent();
        for(int i = 0; i < 5; i++)
        {
            things[i]=new RadioButton();
            things[i].SetBounds(100,150+90*i,200, 100);
            things[i].Font = new Font("·s²Ó©úÅé", 25F, FontStyle.Regular);
            things[i].Text = "test";
            Controls.Add(things[i]);
        }
    }

}
