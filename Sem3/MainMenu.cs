using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem3
{
  public partial class MainMenu : Form
  {
    public MainMenu()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      Dichotomy DichotomyForm = new Dichotomy(this);
      this.Hide();
      DichotomyForm.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Newton NewtonForm = new Newton(this);
      this.Hide();
      NewtonForm.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Sort SortForm = new Sort(this);
      this.Hide();
      SortForm.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Spusk SpuskForm = new Spusk(this);
      this.Hide();
      SpuskForm.Show();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      Integral IntegralForm = new Integral(this);
      this.Hide();
      IntegralForm.Show();
    }

    private void button6_Click(object sender, EventArgs e)
    {
      SLAU SLAUForm = new SLAU(this);
      this.Hide();
      SLAUForm.Show();
    }

    private void button7_Click(object sender, EventArgs e)
    {
      MNK MNKForm = new MNK(this);
      this.Hide();
      MNKForm.Show();
    }
  }
}