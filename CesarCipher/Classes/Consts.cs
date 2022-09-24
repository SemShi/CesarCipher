using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesarCipher.Classes
{
    internal class Consts
    {
        public static Dictionary<char, decimal> freqRusLetters = new Dictionary<char, decimal>()
        {
            {'о',0.10983m },
            {'е',0.08483m },
            {'а',0.07998m },
            {'и',0.07367m },
            {'н',0.067m },
            {'т',0.06318m },
            {'с',0.05473m },
            {'р',0.04746m },
            {'в',0.04533m },
            {'л',0.04343m },
            {'к',0.03486m },
            {'м',0.03203m },
            {'д',0.02977m },
            {'п',0.02804m },
            {'у',0.02615m },
            {'я',0.02001m },
            {'ы',0.01898m },
            {'ь',0.01735m },
            {'г',0.01687m },
            {'з',0.01641m },
            {'б',0.01592m },
            {'ч',0.0145m },
            {'й',0.01208m },
            {'х',0.00966m },
            {'ж',0.0094m },
            {'ш',0.00718m },
            {'ю',0.00639m },
            {'ц',0.00486m },
            {'щ',0.00361m },
            {'э',0.00331m },
            {'ф',0.00267m },
            {'ъ',0.00037m },
            {'ё',0.00013m }
        };
    }
}
