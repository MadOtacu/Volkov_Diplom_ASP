using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volkov_Diplom.Models;

namespace Volkov_Diplom.Services
{
    static class HelpBoxService
    {

        public static void addHelpText(string text)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                HelpBox helpbox = new HelpBox(text);

                context.HelpBoxes.Add(helpbox);
                context.SaveChanges();

            };

        }

        public static void editHelpText(int id, string text)
        {
            using (ApplicationContext context = new ApplicationContext())
            {

                HelpBox helpBox = context.HelpBoxes.Find(id);
                helpBox.text = text;

                //  context.HelpBoxes.Any(helpbox => helpbox.id == id);
                if (helpBox != null)
                {
                    context.HelpBoxes.Update(helpBox);

                    context.SaveChanges();
                }
                else
                {
                    System.Windows.MessageBox.Show("Не найдена справка");
                }

            };

        }


        public static List<HelpBox> getHelpText()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                List<HelpBox> helpBoxes = context.HelpBoxes.ToList() as List<HelpBox>;

                return helpBoxes;

            }
                
        }
    }
}
