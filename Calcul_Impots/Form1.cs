using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul_Impots
{
    public partial class Form1 : Form
    {
        static double Parts(int children, bool married)
        {
            double nbParts;
            if (married) nbParts = children / 2 + 2;
            else nbParts = children / 2 + 1;
            if (children > 3) nbParts += 0.5;
            return nbParts;
        }
        //tableau donné
        double[] champ1 = new double[] { 4262, 8382, 14753, 23888, 38868, 47932, 0 };
        double[] champ2 = new double[] { 0, 0.0683, 0.1914, 0.2826, 0.3738, .4262, .4809 };
        double[] champ3 = new double[] { 0, 291.09, 1322.92, 2668.39, 4846.98, 6883.66, 9505.54 };
        int nbEnfants, salaire, i;
        bool married;
        double nbParts, revenuImposable, qF, impot;

        public Form1(){
            InitializeComponent();
            nbEnfants = 0;
            nbParts = Parts(nbEnfants, married);
            i = 0;
        }

        private void exit_Click(object sender, EventArgs e){
            Environment.Exit(0);
        }

        private void notMarried_CheckedChanged(object sender, EventArgs e){
            married = false;
        }

        private void marrie_CheckedChanged(object sender, EventArgs e){
            married = true;
        } 

        private void child_ValueChanged(object sender, EventArgs e){
            nbEnfants = (int) child.Value;
        }

        private void calc_Click(object sender, EventArgs e){
            revenuImposable = 0.72 * salaire;
            qF = revenuImposable / nbParts;
            i = 0;
            for(int j = 0; j < champ1.Length; j++){
                if (qF > champ1[i]) i++;
            }
            impot = revenuImposable * champ2[i] - nbParts * champ3[i];
            tax.Text = Convert.ToString(impot);
        }

        private void clear_Click(object sender, EventArgs e){
            notMarried.Checked = true;
            child.Value = 0;
            salary.Text = "";
            tax.Text = "";
        }

        private void salary_TextChanged(object sender, EventArgs e){
            int.TryParse(salary.Text,out salaire);
        }
    }
}
