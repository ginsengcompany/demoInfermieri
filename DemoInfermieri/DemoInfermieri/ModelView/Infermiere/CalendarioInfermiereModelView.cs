using DemoInfermieri.Views.Infermere;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace DemoInfermieri.ModelView.Infermiere
{
    class CalendarioInfermiereModelView : INotifyPropertyChanged
    {
        #region DichiarazioneVariabili

        public event PropertyChangedEventHandler PropertyChanged; //evento che implementa l'interfaccia INotifyPropertyChanged
        #endregion

        protected virtual void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public CalendarioInfermiereModelView(CalendarioInfermiere CalendarioInfermiere)
        {

        }

        public void CreaGrid(Grid grid)
        {
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });

            for (int i = 0; i < 24; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
                int temp=i+ 1;
                string ora1 = "";
                string ora2 = "";
                if (i < 9)
                {
                    ora1 = "0" + i.ToString();
                    ora2 = "0" + temp.ToString();
                }
                else if (i == 9)
                {
                    ora1 = "0" + i.ToString();
                    ora2 = temp.ToString();
                }
                else
                {
                    ora1 =  i.ToString();
                    ora2 =  temp.ToString();
                }

                Label ora = new Label
                {
                    Text =ora1 + " - " + ora2,
                    FontAttributes = FontAttributes.Bold,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };
                Label disponibilità = new Label
                {
                    Text = "Disponibile",
                    TextColor = Color.Green,
                    FontAttributes = FontAttributes.Bold,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };
                Switch switchDisponibilità = new Switch
                {

                };
                grid.Children.Add(ora,0,i);
                grid.Children.Add(disponibilità, 1, i);
                grid.Children.Add(switchDisponibilità, 2, i);
            }
        }
    }
}
