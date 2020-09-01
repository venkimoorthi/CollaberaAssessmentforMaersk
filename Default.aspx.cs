using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PromotionEngine
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //clear values
            lblResult.Text = "";
            lblErrorMsg.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //initialize values
            int qtyA = 0;
            int qtyB = 0;
            int qtyC = 0;
            int qtyD = 0;

            //check value is null or empty 
            if (!string.IsNullOrEmpty(txtQtyA.Text.ToString()))
            {
                qtyA = Convert.ToInt32(txtQtyA.Text.ToString());
            }

            //check value is null or empty
            if (!string.IsNullOrEmpty(txtQtyB.Text.ToString()))
            {
                qtyB = Convert.ToInt32(txtQtyB.Text.ToString());
            }

            //check value is null or empty
            if (!string.IsNullOrEmpty(txtQtyC.Text.ToString()))
            {
                qtyC = Convert.ToInt32(txtQtyC.Text.ToString());
            }

            //check value is null or empty
            if (!string.IsNullOrEmpty(txtQtyD.Text.ToString()))
            {
                qtyD = Convert.ToInt32(txtQtyD.Text.ToString());
            }

            //check condition for both value and select all checkbox options
            if ((qtyA >= 0 && chkA.Checked) || (qtyB >= 0 && chkB.Checked) || (qtyC >= 0 && chkC.Checked) || (qtyD >= 0 && chkD.Checked))
            {
                if (chkA.Checked || chkB.Checked || chkC.Checked || chkD.Checked)
                {
                    if (qtyA == 1 && qtyB == 1 && qtyC == 1 && qtyD == 1)
                    {
                        callAPromotion(1, qtyA, qtyB, qtyC, qtyD);
                    }

                    if (qtyA >= 3 && qtyB == 1)
                    {
                        callAPromotion(2, qtyA, qtyB, qtyC, qtyD);
                    }

                    if (qtyB >= 2 && qtyA == 1)
                    {
                        callAPromotion(3, qtyA, qtyB, qtyC, qtyD);
                    }

                    if (qtyA >= 3 && qtyB >= 2)
                    {
                        callAPromotion(4, qtyA, qtyB, qtyC, qtyD);
                    }

                    if (qtyA >= 3 && qtyB >= 2 && qtyC == 1 && qtyD == 1)
                    {
                        callAPromotion(5, qtyA, qtyB, qtyC, qtyD);
                    }

                    if (qtyA >= 3 && qtyB >= 2 && qtyC >= 1 && qtyD == 0)
                    {
                        callAPromotion(6, qtyA, qtyB, qtyC, qtyD);
                    }

                    if (qtyA >= 3 && qtyB >= 2 && qtyD >= 1 && qtyC == 0)
                    {
                        callAPromotion(7, qtyA, qtyB, qtyC, qtyD);
                    }

                    if (qtyA >= 3 && qtyB >= 2 && qtyC > 1 && qtyD == 1)
                    {
                        callAPromotion(8, qtyA, qtyB, qtyC, qtyD);
                    }

                    if (qtyA >= 3 && qtyB >= 2 && qtyD > 1 && qtyC == 1)
                    {
                        callAPromotion(9, qtyA, qtyB, qtyC, qtyD);
                    }

                    if (qtyA >= 1 || qtyB >= 1 || qtyD >= 1 || qtyC >= 1)
                    {
                        callAPromotion(10, qtyA, qtyB, qtyC, qtyD);
                    }
                }

                //check condition for both option C and option D only
                if (chkC.Checked && chkD.Checked && !chkA.Checked && !chkB.Checked)
                {
                    if (qtyC == 1 && qtyD == 1)
                    {
                        callBPromotion(1, qtyA, qtyB, qtyC, qtyD);
                    }
                    else if (qtyC >= 1 && qtyD == 0)
                    {
                        callBPromotion(2, qtyA, qtyB, qtyC, qtyD);
                    }
                    else if (qtyD >= 1 && qtyC == 0)
                    {
                        callBPromotion(3, qtyA, qtyB, qtyC, qtyD);
                    }

                    if (qtyC > 1 && qtyD == 1)
                    {
                        callCPromotion(1, qtyA, qtyB, qtyC, qtyD);
                    }
                    else if (qtyD > 1 && qtyC == 1)
                    {
                        callCPromotion(2, qtyA, qtyB, qtyC, qtyD);
                    }
                }
            }
            else
            {
                lblErrorMsg.Text = "Please select option to add quantity.";
            }
        }

        protected void callAPromotion(int option, int qtyA, int qtyB, int qtyC, int qtyD)
        {
            //calculate Total order value based on option
            if (option == 1)
            {
                lblResult.Text = "Total Order Value : " + Convert.ToString(
                                     qtyA * 50 +
                                     qtyB * 30 +
                                     qtyC * 20 +
                                     qtyD * 15);
            }
            else if (option == 2)
            {
                lblResult.Text = "Total Order Value : " + Convert.ToString(
                          (qtyA / 3) * 130 + (qtyA % 3) * 50 +
                                 qtyB * 30 +
                                 qtyC * 20 +
                                 qtyD * 15);
            }
            else if (option == 3)
            {
                lblResult.Text = "Total Order Value : " + Convert.ToString(
                                   qtyA * 50 +
                                   (qtyB / 2) * 45 + (qtyB % 2) * 30 +
                                    qtyC * 20 +
                                    qtyD * 15);
            }
            else if (option == 4)
            {
                lblResult.Text = "Total Order Value : " + Convert.ToString(
                                   (qtyA / 3) * 130 + (qtyA % 3) * 50 +
                                   (qtyB / 2) * 45 + (qtyB % 2) * 30 +
                                    qtyC * 20 +
                                    qtyD * 15);
            }
            else if (option == 5)
            {
                lblResult.Text = "Total Order Value : " + Convert.ToString(
                                 (qtyA / 3) * 130 + (qtyA % 3) * 50 +
                                 (qtyB / 2) * 45 + (qtyB % 2) * 30 +
                                 30);
            }
            else if (option == 6)
            {
                lblResult.Text = "Total Order Value : " + Convert.ToString(
                                 (qtyA / 3) * 130 + (qtyA % 3) * 50 +
                                 (qtyB / 2) * 45 + (qtyB % 2) * 30 +
                                 qtyC * 20);
            }
            else if (option == 7)
            {
                lblResult.Text = "Total Order Value : " + Convert.ToString(
                                 (qtyA / 3) * 130 + (qtyA % 3) * 50 +
                                 (qtyB / 2) * 45 + (qtyB % 2) * 30 +
                                 qtyD * 15);
            }
            else if (option == 8)
            {
                lblResult.Text = "Total Order Value : " + Convert.ToString(
                                 (qtyA / 3) * 130 + (qtyA % 3) * 50 +
                                 (qtyB / 2) * 45 + (qtyB % 2) * 30 +
                                  (((qtyC - qtyD) * 20) + (qtyD * 30)));
            }
            else if (option == 9)
            {
                lblResult.Text = "Total Order Value : " + Convert.ToString(
                                 (qtyA / 3) * 130 + (qtyA % 3) * 50 +
                                 (qtyB / 2) * 45 + (qtyB % 2) * 30 +
                                 (((qtyC - qtyD) * 15) + (qtyD * 30)));
            }
            else if (option == 10)
            {
                lblResult.Text = "Total Order Value : " + Convert.ToString(
                                     qtyA * 50 +
                                     qtyB * 30 +
                                     qtyC * 20 +
                                     qtyD * 15);
            }
            else
            {
                lblResult.Text = "Total Order Value : 0 ";
            }
        }

        protected void callBPromotion(int option, int qtyA, int qtyB, int qtyC, int qtyD)
        {
            //calculate Total order value based on option
            if (option == 1)
            {
                lblResult.Text = "Total Order Value : " + Convert.ToString(
                                 qtyA * 50 +
                                 qtyB * 30 +
                                 30);
            }
            else if (option == 2)
            {
                lblResult.Text = "Total Order Value : " + Convert.ToString(
                                 qtyA * 50 +
                                 qtyB * 30 +
                                 qtyC * 20);
            }
            else if (option == 3)
            {
                lblResult.Text = "Total Order Value : " + Convert.ToString(
                                 qtyA * 50 +
                                 qtyB * 30 +
                                 qtyD * 15);
            }
        }

        protected void callCPromotion(int option, int qtyA, int qtyB, int qtyC, int qtyD)
        {
            //calculate Total order value based on option
            if (option == 1)
            {
                lblResult.Text = "Total Order Value : " + Convert.ToString(
                                 qtyA * 50 +
                                 qtyB * 30 +
                                 (((qtyC - qtyD) * 20) + (qtyD * 30)));
            }
            else if (option == 2)
            {
                lblResult.Text = "Total Order Value : " + Convert.ToString(
                                 qtyA * 50 +
                                 qtyB * 30 +
                                 (((qtyC - qtyD) * 15) + (qtyD * 30)));
            }
        }

    }
}