using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGC_filetester.Typer
{
    enum transkod
    {
        
	INBETALNING = 82,
    UTBETALNING = 32
    
};
    enum periodkod
    {
        ENGÅNG = 0,
        EN_GÅNG_PER_MÅNAD = 1,
        EN_GÅNG_PER_KVARTAL = 2,
        EN_GÅNG_PER_HALVAR = 3,
        EN_GÅNG_PER_ÅR = 4,
        EN_GÅNG_PER_MÅNAD_SISTA_KALENDER_DAG = 5,
        EN_GÅNG_PER_KVARTAL_SISTA_KALENDER_DAG = 6,
        EN_GÅNG_PER_PERHALVÅR_SISTA_KALENDER_DAG = 7,
        EN_GÅNG_PER_ÅR_SISTA_KALENDER_DAG = 8



    };
  
}
