using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Elementi;

namespace GiocoScacchi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Schiera();
        }


        bool spostare = true;
        Pedina daSpostare;
        Scacchiera s = Scacchiera.Istanza;
        IDictionary<string, Posizione> Posizioni = Scacchiera.Istanza.Posizioni;
        Button precedente;

        private void Schiera()
        {

            for (char c = 'A'; c <= 'H'; c++)
            {
                for (int n = 1; n <= 8; n++)
                {
                    s.Posizioni[$"{c}{n}"].Pedina = null;
                }
            }

            // Riga 8

            Torre TorreNera1 = new Torre(Colore.Nero)
            {
                Posizione = s.GetPosizione('A', 8)
            };
            A8.Content = TorreNera1.Name;

            Cavallo CavalloNero1 = new Cavallo(Colore.Nero)
            {
                Posizione = s.GetPosizione('B', 8)
            };
            B8.Content = CavalloNero1.Name;

            Alfiere AlfiereNero1 = new Alfiere(Colore.Nero)
            {
                Posizione = s.GetPosizione('C', 8)
            };
            C8.Content = AlfiereNero1.Name;

            Re ReNero = new Re(Colore.Nero)
            {
                Posizione = s.GetPosizione('D', 8)
            };
            D8.Content = ReNero.Name;

            Regina ReginaNera = new Regina(Colore.Nero)
            {
                Posizione = s.GetPosizione('E', 8)
            };
            E8.Content = ReginaNera.Name;

            Alfiere AlfiereNero2 = new Alfiere(Colore.Nero)
            {
                Posizione = s.GetPosizione('F', 8)
            };
            F8.Content = AlfiereNero2.Name;

            Cavallo CavalloNero2 = new Cavallo(Colore.Nero)
            {
                Posizione = s.GetPosizione('G', 8)
            };
            G8.Content = CavalloNero2.Name;

            Torre TorreNera2 = new Torre(Colore.Nero)
            {
                Posizione = s.GetPosizione('H', 8)
            };
            H8.Content = TorreNera2.Name;

            // Riga 7

            Pedone PedoneNero1 = new Pedone(Colore.Nero)
            {
                Posizione = s.GetPosizione('A', 7)
            };
            A7.Content = PedoneNero1.Name;

            Pedone PedoneNero2 = new Pedone(Colore.Nero)
            {
                Posizione = s.GetPosizione('B', 7)
            };
            B7.Content = PedoneNero2.Name;

            Pedone PedoneNero3 = new Pedone(Colore.Nero)
            {
                Posizione = s.GetPosizione('C', 7)
            };
            C7.Content = PedoneNero3.Name;

            Pedone PedoneNero4 = new Pedone(Colore.Nero)
            {
                Posizione = s.GetPosizione('D', 7)
            };
            D7.Content = PedoneNero4.Name;

            Pedone PedoneNero5 = new Pedone(Colore.Nero)
            {
                Posizione = s.GetPosizione('E', 7)
            };
            E7.Content = PedoneNero5.Name;

            Pedone PedoneNero6 = new Pedone(Colore.Nero)
            {
                Posizione = s.GetPosizione('F', 7)
            };
            F7.Content = PedoneNero6.Name;

            Pedone PedoneNero7 = new Pedone(Colore.Nero)
            {
                Posizione = s.GetPosizione('G', 7)
            };
            G7.Content = PedoneNero7.Name;

            Pedone PedoneNero8 = new Pedone(Colore.Nero)
            {
                Posizione = s.GetPosizione('H', 7)
            };
            H7.Content = PedoneNero8.Name;

            // Riga 2

            Pedone PedoneBianco1 = new Pedone(Colore.Bianco)
            {
                Posizione = s.GetPosizione('A', 2)
            };
            A2.Content = PedoneBianco1.Name;

            Pedone PedoneBianco2 = new Pedone(Colore.Bianco)
            {
                Posizione = s.GetPosizione('B', 2)
            };
            B2.Content = PedoneBianco2.Name;

            Pedone PedoneBianco3 = new Pedone(Colore.Bianco)
            {
                Posizione = s.GetPosizione('C', 2)
            };
            C2.Content = PedoneBianco3.Name;

            Pedone PedoneBianco4 = new Pedone(Colore.Bianco)
            {
                Posizione = s.GetPosizione('D', 2)
            };
            D2.Content = PedoneBianco4.Name;

            Pedone PedoneBianco5 = new Pedone(Colore.Bianco)
            {
                Posizione = s.GetPosizione('E', 2)
            };
            E2.Content = PedoneBianco5.Name;

            Pedone PedoneBianco6 = new Pedone(Colore.Bianco)
            {
                Posizione = s.GetPosizione('F', 2)
            };
            F2.Content = PedoneBianco6.Name;

            Pedone PedoneBianco7 = new Pedone(Colore.Bianco)
            {
                Posizione = s.GetPosizione('G', 2)
            };
            G2.Content = PedoneBianco7.Name;

            Pedone PedoneBianco8 = new Pedone(Colore.Bianco)
            {
                Posizione = s.GetPosizione('H', 2)
            };
            H2.Content = PedoneBianco8.Name;

            // Riga 1

            Torre TorreBianca1 = new Torre(Colore.Bianco)
            {
                Posizione = s.GetPosizione('A', 1)
            };
            A1.Content = TorreBianca1.Name;

            Cavallo CavalloBianco1 = new Cavallo(Colore.Bianco)
            {
                Posizione = s.GetPosizione('B', 1)
            };
            B1.Content = CavalloBianco1.Name;

            Alfiere AlfiereBianco1 = new Alfiere(Colore.Bianco)
            {
                Posizione = s.GetPosizione('C', 1)
            };
            C1.Content = AlfiereBianco1.Name;

            Re ReBianco = new Re(Colore.Bianco)
            {
                Posizione = s.GetPosizione('D', 1)
            };
            D1.Content = ReBianco.Name;

            Regina ReginaBianca = new Regina(Colore.Bianco)
            {
                Posizione = s.GetPosizione('E', 1)
            };
            E1.Content = ReginaBianca.Name;

            Alfiere AlfiereBianco2 = new Alfiere(Colore.Bianco)
            {
                Posizione = s.GetPosizione('F', 1)
            };
            F1.Content = AlfiereBianco2.Name;

            Cavallo CavalloBianco2 = new Cavallo(Colore.Bianco)
            {
                Posizione = s.GetPosizione('G', 1)
            };
            G1.Content = CavalloBianco2.Name;

            Torre TorreBianca2 = new Torre(Colore.Bianco)
            {
                Posizione = s.GetPosizione('H', 1)
            };
            H1.Content = TorreBianca2.Name;

        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["B7"].Pedina;
                    B7.Content = "";
                    spostare = false;
                    precedente = B7;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    B7.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["B7"]);
                    B7.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["B6"].Pedina;
                    B6.Content = "";
                    spostare = false;
                    precedente = B6;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    B6.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["B6"]);
                    B6.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["B5"].Pedina;
                    B5.Content = "";
                    spostare = false;
                    precedente = B5;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    B5.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["B5"]);
                    B5.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void A8_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["A8"].Pedina;
                    A8.Content = "";
                    spostare = false;
                    precedente = A8;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    A8.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["A8"]);
                    A8.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["B8"].Pedina;
                    B8.Content = "";
                    spostare = false;
                    precedente = B8;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    B6.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["B8"]);
                    B8.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void C8_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["C8"].Pedina;
                    C8.Content = "";
                    spostare = false;
                    precedente = C8;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    C8.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["C8"]);
                    C8.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void D8_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["D8"].Pedina;
                    D8.Content = "";
                    spostare = false;
                    precedente = D8;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    D8.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["D8"]);
                    D8.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void E8_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["E8"].Pedina;
                    E8.Content = "";
                    spostare = false;
                    precedente = E8;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    E8.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["E8"]);
                    E8.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void F8_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["F8"].Pedina;
                    F8.Content = "";
                    spostare = false;
                    precedente = F8;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    F8.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["F8"]);
                    F8.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void G8_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["G8"].Pedina;
                    G8.Content = "";
                    spostare = false;
                    precedente = G8;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    G8.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["G8"]);
                    G8.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void H8_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["H8"].Pedina;
                    H8.Content = "";
                    spostare = false;
                    precedente = H8;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    H8.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["H8"]);
                    H8.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void A7_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["A7"].Pedina;
                    A7.Content = "";
                    spostare = false;
                    precedente = A7;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    A7.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["A7"]);
                    A7.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void C7_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["C7"].Pedina;
                    C7.Content = "";
                    spostare = false;
                    precedente = C7;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    C7.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["C7"]);
                    C7.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void D7_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["D7"].Pedina;
                    D7.Content = "";
                    spostare = false;
                    precedente = D7;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    D7.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["D7"]);
                    D7.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void E7_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["E7"].Pedina;
                    E7.Content = "";
                    spostare = false;
                    precedente = E7;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    E7.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["E7"]);
                    E7.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void F7_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["F7"].Pedina;
                    F7.Content = "";
                    spostare = false;
                    precedente = F7;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    F7.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["F7"]);
                    F7.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void G7_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["G7"].Pedina;
                    G7.Content = "";
                    spostare = false;
                    precedente = G7;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    G7.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["G7"]);
                    G7.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void H7_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["H7"].Pedina;
                    H7.Content = "";
                    spostare = false;
                    precedente = H7;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    H7.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["H7"]);
                    H7.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void A6_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["A6"].Pedina;
                    A6.Content = "";
                    spostare = false;
                    precedente = A6;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    A6.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["A6"]);
                    A6.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void C6_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["C6"].Pedina;
                    C6.Content = "";
                    spostare = false;
                    precedente = C6;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    C6.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["C6"]);
                    C6.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void D6_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["D6"].Pedina;
                    D6.Content = "";
                    spostare = false;
                    precedente = D6;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    D6.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["D6"]);
                    D6.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void E6_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["E6"].Pedina;
                    E6.Content = "";
                    spostare = false;
                    precedente = E6;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    E6.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["E6"]);
                    E6.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void F6_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["F6"].Pedina;
                    F6.Content = "";
                    spostare = false;
                    precedente = F6;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    F6.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["F6"]);
                    F6.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void G6_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["G6"].Pedina;
                    G6.Content = "";
                    spostare = false;
                    precedente = G6;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    G6.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["G6"]);
                    G6.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void H6_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["H6"].Pedina;
                    H6.Content = "";
                    spostare = false;
                    precedente = H6;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    H6.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["H6"]);
                    H6.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void A5_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["A5"].Pedina;
                    A5.Content = "";
                    spostare = false;
                    precedente = A5;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    A5.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["A5"]);
                    A5.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void C5_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["C5"].Pedina;
                    C5.Content = "";
                    spostare = false;
                    precedente = C5;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    C5.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["C5"]);
                    C5.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void D5_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["D5"].Pedina;
                    D5.Content = "";
                    spostare = false;
                    precedente = D5;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    D5.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["D5"]);
                    D5.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void E5_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["E5"].Pedina;
                    E5.Content = "";
                    spostare = false;
                    precedente = E5;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    E5.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["E5"]);
                    E5.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void F5_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["F5"].Pedina;
                    F5.Content = "";
                    spostare = false;
                    precedente = F5;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    F5.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["F5"]);
                    F5.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void G5_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["G5"].Pedina;
                    G5.Content = "";
                    spostare = false;
                    precedente = G5;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    G5.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["G5"]);
                    G5.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }

        private void H5_Click(object sender, RoutedEventArgs e)
        {
            if (spostare == true)
            {
                try
                {
                    daSpostare = s.Posizioni["H5"].Pedina;
                    H5.Content = "";
                    spostare = false;
                    precedente = H5;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    H5.Content = daSpostare.Name;
                }
            }
            else
            {
                try
                {
                    daSpostare.Muovi(s.Posizioni["H5"]);
                    H5.Content = daSpostare.Name;
                    spostare = true;
                    daSpostare = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    spostare = true;
                    precedente.Content = daSpostare.Name;
                    precedente = null;
                }
            }
        }
    }
}
