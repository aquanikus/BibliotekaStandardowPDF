using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotekaStandardowPDF.Models;
using DocumentFormat.OpenXml.Drawing;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

namespace BibliotekaStandardowPDF.Controllers
{
    public class PDFController : Controller
    {
        public IActionResult Templatka(string Orientation)
        {
            Dokument dok = new Dokument
            {
                Temat = "PRA-Q-OPL-01-Projekt testowy jakiśtam",
                Tresc = "<p><b>sthfhgfhgf</b></p><p><img src='data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACAAAAAhCAYAAAC4JqlRAAACI0lEQVRYCc2Vy43CQBBEHcvGs+RBEIRABCTAeblz5sqVI0duZDCrsvRG5fb8QLsSLaG2xzVV1T1tM6UX4+vnO7V+L9KlaWSDC/bwr2DF1TUgwndjZG/VAJW8K86+Hk/RwIhzBEZzjXNloAYcFWrhStyfZQCHz+cz3e/3VjHzs1GcwPChAXnuAA+u12uapin/Ho8H2EU+Ho8ZI3wNd7lcMm6/388caOlmZUBEbkAEpdhutwvc+XwuwdLhcMg4XStWBnxBgM1mkzep0hhqvZvUNdVFrHN5MWjOHeCGze5alcaIx4SZiItGdU+gWTTg5yZy3yiC0+m06oBwDBoibjQWkg1wwSblOAe3280fp91ulw34dZwDN1o6SmlPJQNS87MTkQctl7iLxDlwc+pGjKYBf81ERKgbGJC432vdA1xcB9M04OfnBF4xVbkQc6DMuheAuHLTQJxgiL2tDKevMQfKGIhHiImmAYH8YwMxpD7V3hXmQBlsHOJhAz4HIvS2+lSX5gBx5Vp0O+BzoLfC28r5Q+6C/h2hI+DIElcUP0SAZoD9MfmryfmD9TlwHEcHjjxswImpUgIxfA7AKTO8Eb8woIcsRGCJmH81x/p8YKBkNGrlCakZKBHXptpbLxOt1w/z2UB0BuCvcyz0swz8dxdi9dJbdIB2C1gC8/ydXOMrGkCgtonnI7lXTNOABHoENROj+7oGEBglHMXBO2yADQjUMrjR/Asf+6h4UwlgOQAAAABJRU5ErkJggg=='></p><ul><li>wpis 1</li><li>wpis 2</li></ul><p><br></p><table class='table table-bordered'><tbody><tr><td>jeden</td><td>dwa</td></tr><tr><td>trzy</td><td>milion pięćset dwieście dziewięćset</td></tr></tbody></table>",
            };
            if (Orientation == "Landscape")
            {
                var report = new ViewAsPdf("Templatka")
                {
                    FileName = "Invoice.pdf",
                    PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape,
                };
                return report;
            }
            else if(Orientation == "Bi")
            {

                return View(dok);
            }
            else
            {
                var report = new ViewAsPdf("Templatka", dok)
                {
                    PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                    CustomSwitches =
                    "--footer-center \"  Created Date: " +
                    DateTime.Now.Date.ToString("dd/MM/yyyy") + "  Page: [page]/[toPage]\"" +
                    " --footer-line --footer-font-size \"12\" --footer-spacing 1 --footer-font-name \"Segoe UI\""
                };
                return report;
            }
        }
    }
}
