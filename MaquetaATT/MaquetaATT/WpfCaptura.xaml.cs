﻿using System;
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
using System.Windows.Shapes;

namespace MaquetaATT
{
	/// <summary>
	/// Interaction logic for WpfCaptura.xaml
	/// </summary>
	public partial class WpfCaptura : Window
	{
		private const string HINT_CLIENTE_AP1 = "Apellido paterno",
							 HINT_CLIENTE_AP2 = "Apellido materno",
							 HINT_CLIENTE_NOMBRES = "Nombres";

		public WpfCaptura()
		{
			InitializeComponent();

			txtClienteAp1.Text = HINT_CLIENTE_AP1;
			txtClienteAp2.Text = HINT_CLIENTE_AP2;
			txtClienteNombres.Text = HINT_CLIENTE_NOMBRES;
		}

		private void txtClienteAp1_GotFocus(object sender, RoutedEventArgs e)
		{
			delegateGotFocus(txtClienteAp1, HINT_CLIENTE_AP1);
		}

		private void txtClienteAp1_LostFocus(object sender, RoutedEventArgs e)
		{
			delegateLostFocus(txtClienteAp1, HINT_CLIENTE_AP1);
		}

		private void txtClienteAp2_GotFocus(object sender, RoutedEventArgs e)
		{
			delegateGotFocus(txtClienteAp2, HINT_CLIENTE_AP2);
		}

		private void txtClienteAp2_LostFocus(object sender, RoutedEventArgs e)
		{
			delegateLostFocus(txtClienteAp2, HINT_CLIENTE_AP2);
		}

		private void txtClienteNombres_GotFocus(object sender, RoutedEventArgs e)
		{
			delegateGotFocus(txtClienteNombres, HINT_CLIENTE_NOMBRES);
		}

		private void txtClienteNombres_LostFocus(object sender, RoutedEventArgs e)
		{
			delegateLostFocus(txtClienteNombres, HINT_CLIENTE_NOMBRES);
		}

		private void delegateGotFocus(TextBox campoTexto, string hint)
		{
			if (campoTexto.Text == hint) { campoTexto.Clear(); }
		}

		private void delegateLostFocus(TextBox campoTexto, string hint)
		{
			if (campoTexto.Text == "") { campoTexto.Text = hint; }
		}
	}
}
