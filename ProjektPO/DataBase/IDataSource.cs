using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO
{
    public interface IDataSource
    {
        //Klasa statyczna nie moze implementować interfejsu.

        List<IItem> WczytajDane();
        void UstawIlosc(IItem obj, int ilosc);
        void DodajElement(IItem obj);
        List<Zamowienie> WyswietlZamowienia();
        void DodajZamowienie(Zamowienie obj);
    }
}
