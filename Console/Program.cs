﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore;
using Web.Controllers;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var modulus = BigInteger.Parse("145906768007583323230186939349070635292401872375357164399581871019873438799005358938369571402670149802121818086292467422828157022922076746906543401224889672472407926969987100581290103199317858753663710862357656510507883714297115637342788911463535102712032765166518411726859837988672111837205085526346618740053");
            var totient = BigInteger.Parse("145906768007583323230186939349070635292401872375357164399581871019873438799005358938369571402670149802121818086292467422828157022922076746906543401224889648313811232279966317301397777852365301547848273478871297222058587457152891606459269718119268971163555070802643999529549644116811947516513938184296683521280");
            var public_key = BigInteger.Parse("65537");
            var private_key = BigInteger.Parse("89489425009274444368228545921773093919669586065884257445497854456487674839629818390934941973262879616797970608917283679875499331574161113854088813275488110588247193077582527278437906504015680623423550067240042466665654232383502922215493623289472138866445818789127946123407807725702626644091036502372545139713");
            var jakhNum = "88462075199656540405120350964125453885735167090041311459820847133046285679277198360413674689658602957582497772031953041871349126020839749165872933368594549892434647265692011335451183940364673015293343736158832498084057991870741007803109909299798716259814528160570784433987801539444614006263565772914019343238";
            var iskNum = "116670286813474143775832603919524241866160654054286115243144086976221227559937878785252134052248131055262558992490299628585113845813964074597746006276074599314007398603385208307218005107283301092598141194016478695399787015952992411599626496527426234287471332327085657628344656968589646306119973079326257150494";
            System.Console.WriteLine(Algorithms.RSADecrypt(private_key, modulus, BigInteger.Parse(jakhNum)));
            System.Console.WriteLine(Algorithms.RSADecrypt(private_key, modulus, BigInteger.Parse(iskNum)));
            System.Console.ReadKey();
        }

    }
}
