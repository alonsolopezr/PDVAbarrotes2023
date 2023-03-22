
using System;
namespace Back_CRUDs_BD
{
	public class ValoresAInsertar
	{
        public string valor;
		public bool llevaApostrofes;

		public ValoresAInsertar(string v, bool llevaApostrofes=true)
		{
			this.valor = v;
			this.llevaApostrofes = llevaApostrofes;
		}
	}
}

