﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPadroesProjeto.Models.Moveis.Futurista
{
	public class PoltronaFuturista : Poltrona
	{
		/// <summary>
		/// Inicializa o objeto Poltrona Futurista invocando o construtor da classe 
		/// Poltrona, passando como parâmetro o modelo.
		/// </summary>
		public PoltronaFuturista() : base("Poltrona Futurista")
		{
			this.URL = "data:image/jpeg;base64,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";
		}
	}
}
