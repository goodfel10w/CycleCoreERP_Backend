using CycleCoreERP_Backend.Models;
using System.Collections.Generic;

namespace CycleCoreERP_Backend.Data
{
    public static class Stueckliste
    {
        public static Dictionary<Fahrrad,
        List<Bauteil>> Bauteile = new Dictionary<Fahrrad,
        List<Bauteil>>() {
            {
                Data.Fahrrad.P1,
                new List < Bauteil > () {
                    new Bauteil(1, 0),
                    new Bauteil(26, 1),
                    new Bauteil(51, 1),
                    new Bauteil(16, 51),
                    new Bauteil(17, 51),
                    new Bauteil(50, 51),
                    new Bauteil(4, 50),
                    new Bauteil(10, 50),
                    new Bauteil(49, 50),
                    new Bauteil(7, 49),
                    new Bauteil(13, 49),
                    new Bauteil(18, 49)
                }
            },
            {
                Data.Fahrrad.P2,
                new List < Bauteil > () {
                    new Bauteil(2, 0),
                    new Bauteil(26, 2),
                    new Bauteil(56, 2),
                    new Bauteil(16, 56),
                    new Bauteil(17, 56),
                    new Bauteil(55, 56),
                    new Bauteil(5, 55),
                    new Bauteil(11, 55),
                    new Bauteil(54, 55),
                    new Bauteil(8, 54),
                    new Bauteil(14, 54),
                    new Bauteil(19, 54)
                }
            },
            {
                Data.Fahrrad.P3,
                new List < Bauteil > () {
                    new Bauteil(3, 0),
                    new Bauteil(26, 3),
                    new Bauteil(31, 3),
                    new Bauteil(16, 31),
                    new Bauteil(17, 31),
                    new Bauteil(30, 31),
                    new Bauteil(6, 30),
                    new Bauteil(12, 30),
                    new Bauteil(29, 30),
                    new Bauteil(9, 29),
                    new Bauteil(15, 29),
                    new Bauteil(20, 29)
                }
            }
        };

        public static Dictionary<Fahrrad,
        List<Kaufteil>> Kaufteile = new Dictionary<Fahrrad,
        List<Kaufteil>>() {
            {
                Data.Fahrrad.P1,
                new List < Kaufteil > () {
                    new Kaufteil(21, 1, 1),
                    new Kaufteil(24, 1, 1),
                    new Kaufteil(27, 1, 1),
                    new Kaufteil(44, 26, 2),
                    new Kaufteil(47, 26, 1),
                    new Kaufteil(48, 26, 2),
                    new Kaufteil(24, 51, 1),
                    new Kaufteil(27, 51, 1),
                    new Kaufteil(24, 16, 1),
                    new Kaufteil(28, 16, 1),
                    new Kaufteil(40, 16, 1),
                    new Kaufteil(41, 16, 1),
                    new Kaufteil(42, 16, 2),
                    new Kaufteil(43, 17, 1),
                    new Kaufteil(44, 17, 1),
                    new Kaufteil(45, 17, 1),
                    new Kaufteil(46, 17, 1),
                    new Kaufteil(24, 50, 2),
                    new Kaufteil(25, 50, 2),
                    new Kaufteil(35, 4, 2),
                    new Kaufteil(36, 4, 1),
                    new Kaufteil(52, 4, 1),
                    new Kaufteil(53, 4, 36),
                    new Kaufteil(32, 10, 1),
                    new Kaufteil(39, 10, 1),
                    new Kaufteil(24, 49, 2),
                    new Kaufteil(25, 49, 2),
                    new Kaufteil(35, 7, 2),
                    new Kaufteil(37, 7, 1),
                    new Kaufteil(38, 7, 1),
                    new Kaufteil(52, 7, 1),
                    new Kaufteil(53, 7, 36),
                    new Kaufteil(32, 13, 1),
                    new Kaufteil(39, 13, 1),
                    new Kaufteil(28, 18, 3),
                    new Kaufteil(32, 18, 1),
                    new Kaufteil(59, 18, 2)
                }
            },
            {
                Data.Fahrrad.P2,
                new List < Kaufteil > () {
                    new Kaufteil(22, 2, 1),
                    new Kaufteil(24, 2, 1),
                    new Kaufteil(27, 2, 1),
                    new Kaufteil(44, 26, 2),
                    new Kaufteil(47, 26, 1),
                    new Kaufteil(48, 26, 2),
                    new Kaufteil(24, 56, 1),
                    new Kaufteil(27, 56, 1),
                    new Kaufteil(24, 16, 1),
                    new Kaufteil(28, 16, 1),
                    new Kaufteil(40, 16, 1),
                    new Kaufteil(41, 16, 1),
                    new Kaufteil(42, 16, 2),
                    new Kaufteil(43, 17, 1),
                    new Kaufteil(44, 17, 1),
                    new Kaufteil(45, 17, 1),
                    new Kaufteil(46, 17, 1),
                    new Kaufteil(24, 55, 2),
                    new Kaufteil(25, 55, 2),
                    new Kaufteil(35, 5, 2),
                    new Kaufteil(36, 5, 1),
                    new Kaufteil(57, 5, 1),
                    new Kaufteil(58, 5, 36),
                    new Kaufteil(32, 11, 1),
                    new Kaufteil(39, 11, 1),
                    new Kaufteil(24, 54, 2),
                    new Kaufteil(25, 54, 2),
                    new Kaufteil(35, 8, 2),
                    new Kaufteil(37, 8, 1),
                    new Kaufteil(38, 8, 1),
                    new Kaufteil(57, 8, 1),
                    new Kaufteil(58, 8, 36),
                    new Kaufteil(32, 14, 1),
                    new Kaufteil(39, 14, 1),
                    new Kaufteil(28, 19, 4),
                    new Kaufteil(32, 19, 1),
                    new Kaufteil(59, 19, 2)
                }
            },
            {
                Data.Fahrrad.P3,
                new List < Kaufteil > ()
                {
                    new Kaufteil(23, 3, 1),
                    new Kaufteil(24, 3, 1),
                    new Kaufteil(27, 3, 1),
                    new Kaufteil(44, 26, 2),
                    new Kaufteil(47, 26, 1),
                    new Kaufteil(48, 26, 2),
                    new Kaufteil(24, 31, 1),
                    new Kaufteil(27, 31, 1),
                    new Kaufteil(24, 16, 1),
                    new Kaufteil(28, 16, 1),
                    new Kaufteil(40, 16, 1),
                    new Kaufteil(41, 16, 1),
                    new Kaufteil(42, 16, 2),
                    new Kaufteil(43, 17, 1),
                    new Kaufteil(44, 17, 1),
                    new Kaufteil(45, 17, 1),
                    new Kaufteil(46, 17, 1),
                    new Kaufteil(24, 30, 2),
                    new Kaufteil(25, 30, 2),
                    new Kaufteil(33, 6, 1),
                    new Kaufteil(34, 6, 36),
                    new Kaufteil(35, 6, 2),
                    new Kaufteil(36, 6, 1),
                    new Kaufteil(32, 12, 1),
                    new Kaufteil(39, 12, 1),
                    new Kaufteil(24, 29, 2),
                    new Kaufteil(25, 29, 2),
                    new Kaufteil(33, 9, 1),
                    new Kaufteil(34, 9, 36),
                    new Kaufteil(35, 9, 2),
                    new Kaufteil(37, 9, 1),
                    new Kaufteil(38, 9, 1),
                    new Kaufteil(32, 15, 1),
                    new Kaufteil(39, 15, 1),
                    new Kaufteil(28, 20, 5),
                    new Kaufteil(32, 20, 1),
                    new Kaufteil(59, 20, 2),
                }
            }
        };
    }

    public enum Fahrrad
    {
        P1 = 1,
        P2,
        P3
    }
}