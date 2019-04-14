//  MovelAbstractFactory.cs
//
//  Author:
//       Alex Pinheiro das Graças <alex.gracas>
//
//  Copyright (c) 2019 
//
//  Este arquivo não pode ser modificado, cedido ou alterado sem a permissão explicita do autor.
using ExemplosPadroesProjeto.Models.Moveis;
using ExemplosPadroesProjeto.Models.Moveis.Romano;

namespace ExemplosPadrõesProjeto.Models.Moveis
{
	internal class MovelRomanoFactory : MovelAbstractFactory
	{
		protected override Armario CriarArmario()
		{
			return new ArmarioRomano();
		}

		protected override Cadeira CriarCadeira()
		{
			return new CadeiraRomano();
		}

		protected override Mesa CriarMesa()
		{
			return new MesaRomano();
		}

		protected override Poltrona CriarPoltrona()
		{
			return new PoltronaRomano();
		}
	}
}