using GymApp.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Test
{
    public class PictParser
    {
        private static readonly string PictResultpath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "PictResults.txt");

        public static IEnumerable<TestCaseData> GetTestCases()
        {

            string[] lines = File.ReadAllLines(PictResultpath);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();


                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("trainingOption"))
                    continue;


                string[] parts = line.Split('\t');

                if (parts.Length < 4)
                    continue;


                string trainingOption = parts[0].Trim();
                string numberOfMonths = parts[1].Trim();
                string monthlyPriceBudget = parts[2].Trim();
                string trainingTime = parts[3].Trim();


                string membershipType = parts.Length > 4 ? parts[4].Trim() : "TypeD";

                yield return new TestCaseData(
                    trainingOption,
                    numberOfMonths,
                    monthlyPriceBudget,
                    trainingTime,
                    membershipType)
                .SetName(
                    $"GetMembershipType_Option={trainingOption}_" +
                    $"Months={numberOfMonths}_" +
                    $"Budget={monthlyPriceBudget}_" +
                    $"Time={trainingTime}_" +
                    $"Expected={membershipType}");
            }
        }

        }
    }
