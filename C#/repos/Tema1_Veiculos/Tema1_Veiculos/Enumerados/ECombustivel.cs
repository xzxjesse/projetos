using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Veiculos.Enumerados
{
    public enum TipoCombustivel
    {
        // veículos terrestres
        Gasolina,
        Etanol,
        Diesel,
        GNV,
        Eletrico,
        Hibrido,

        // veículos aéreos
        QueroseneDeAviacao,
        AvGas,
        Biocombustivel,
        Hidrogenio,

        // veículos marítimos
        DieselMaritimo,
        CombustivelMarinho,
        GasNaturalLiquefeito,
        Nuclear,
        EnergiaSolar,
    }
}
