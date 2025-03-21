﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Alunos
{
	class CPF
	{
		public static bool ValidaCPF(string cpf)
		{
			try
			{
				int[] multi1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
				int[] multi2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

				string tempCPF;
				string digito;
				int soma;
				int resto;

				if (cpf.Length != 11)
					cpf = cpf.Trim();
				cpf = cpf.Replace(".", "").Replace("-", "");
				if (cpf.Distinct().Count() == 1)
					return false;

				tempCPF = cpf.Substring(0, 9);
				soma = 0;

				for (int cont = 0; cont < 9; cont++)
					soma += int.Parse(tempCPF[cont].ToString()) * multi1[cont];

				resto = soma % 11;
				if (resto < 2)
					resto = 0;
				else
					resto = 11 - resto;
				digito = resto.ToString();
				tempCPF = tempCPF + digito;

				soma = 0;
				for (int cont = 0; cont < 10; cont++)
					soma += int.Parse(tempCPF[cont].ToString()) * multi2[cont];
				resto = soma % 11;

				if (resto < 2)
					resto = 0;
				else
					resto = 11 - resto;
				digito = digito + resto.ToString();

				return cpf.EndsWith(digito);
			}
			catch
			{
				return false;
			}
		}
	}
}
