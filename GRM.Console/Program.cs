using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using GRM.Console.Entities;

namespace GRM.Console
{
    public class Program
    {
        private static void Main(string[] args)
        {

            // Read Music titles
            var musicCollection = new List<Music>();
            using (var sr = new StreamReader("../../Data/music.txt"))
            {
                var count = 0;
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine();
                    count++;
                    if (count != 1)
                    {
                        var row = line?.Split('|');
                        musicCollection.Add(new Music
                        {
                            Artist = row[0],
                            Title = row[1],
                            Usage = row[2],
                            StartDate =
                                DateTime.Parse(
                                    row[3].RemoveOrdinals()),
                            EndDate =
                                string.IsNullOrEmpty(row[4])
                                    ? new DateTime?()
                                    : DateTime.Parse(
                                        row[4].RemoveOrdinals())
                        });
                    }
                }
            }

            //Read Distribution Parters file

            var partnerCollection = new List<DistributionPartner>();
            using (var sr = new StreamReader("../../Data/partner.txt"))
            {
                var count = 0;
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine();
                    count++;
                    if (count != 1)
                    {
                        var row = line?.Split('|');
                        partnerCollection.Add(new DistributionPartner
                        {
                            Partner = row[0],
                            Usage = row[1]
                        });
                    }
                }
            }
            System.Console.WriteLine("Input :");
            var input = System.Console.ReadLine();
            if (input != null)
            {
                var partner = input.Substring(0, input.IndexOf(" ", StringComparison.Ordinal));
                var effectiveDate =
                    DateTime.Parse(
                        input.Substring(input.IndexOf(" ", StringComparison.Ordinal),
                            input.Length - input.IndexOf(" ", StringComparison.Ordinal)).Trim().RemoveOrdinals());

                var usage = partnerCollection.FirstOrDefault(
                    p => p.Partner.Equals(partner, StringComparison.OrdinalIgnoreCase))?.Usage;
           
                //check if it's legal to distribute a particular title
                var output =
                    musicCollection.Where(
                            m =>
                                m.Usage.Split(',').Any(t => t.Trim() == usage
                                )
                                && (m.StartDate.HasValue
                                    ? m.StartDate.Value.CompareTo(effectiveDate) < 0 : false)
                                &&(
                                    m.EndDate.HasValue ? m.EndDate.Value.CompareTo(effectiveDate) > 0 : true)
                        )
                        .ToList();
                output.ForEach(o => o.Usage = usage);
                System.Console.WriteLine("Artist|Title|Usage|StartDate|EndDate");
                System.Console.WriteLine(string.Join("", output));
            }
            System.Console.Read();
        }
    }
}
