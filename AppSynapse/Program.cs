using System;
using BiblioSynapse;

namespace AppSynapse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration des variables 
            int nbHeures;

            //Création du jeu d'essai
            Intervenant pierre = new Intervenant("Pierre", 15);
            Intervenant paul = new Intervenant("Paul", 20);
            Intervenant jacques = new Intervenant("Jacques", 10);
            DateTime debut = new DateTime(2024, 01, 01);
            DateTime fin = new DateTime(2024, 01, 31);
            DateTime laDate;

            Projet p = new Projet("Delta", debut, fin, 10000);

            Mission m1 = new Mission("M1", "Création des classes", 200, pierre);
            Mission m2 = new Mission("M2", "Tests des classes", 100, paul);
            Mission m3 = new Mission("M3", "Factorisation des méthodes de classes", 100, jacques);

            p.affecterMission(m1);
            p.affecterMission(m2);
            p.affecterMission(m3);

            laDate = new DateTime(2024, 01, 03);
            m1.ajoutReleve(laDate, 8);
            laDate = new DateTime(2024, 01, 04);
            m1.ajoutReleve(laDate, 4);
            nbHeures = m1.ReleveHoraire[laDate];
            laDate = new DateTime(2024, 01, 05);
            m1.ajoutReleve(laDate, 4);
            laDate = new DateTime(2024, 01, 06);
            m1.ajoutReleve(laDate, 4);
            laDate = new DateTime(2024, 01, 07);
            m1.ajoutReleve(laDate, 8);
            m1.afficherReleveHoraire();
            laDate = new DateTime(2024, 01, 10);
            m2.ajoutReleve(laDate, 4);
            laDate = new DateTime(2024, 01, 11);
            m2.ajoutReleve(laDate, 4);
            laDate = new DateTime(2024, 01, 12);
            m2.ajoutReleve(laDate, 8);
            laDate = new DateTime(2024, 01, 13);
            m2.ajoutReleve(laDate, 8);
            laDate = new DateTime(2022, 01, 14);
            m2.ajoutReleve(laDate, 4);
            m2.afficherReleveHoraire();
            laDate = new DateTime(2024, 01, 17);
            m3.ajoutReleve(laDate, 4);
            laDate = new DateTime(2024, 01, 18);
            m3.ajoutReleve(laDate, 4);
            laDate = new DateTime(2024, 01, 19);
            m3.ajoutReleve(laDate, 4);
            laDate = new DateTime(2024, 01, 20);
            m3.ajoutReleve(laDate, 4);
            laDate = new DateTime(2024, 01, 21);
            m3.ajoutReleve(laDate, 4);
            m3.afficherReleveHoraire();

            //Affichage de la marge de brute du projet créé
            Console.WriteLine("Marge brute du projet : " + p.margeBruteCourante());

            Console.ReadKey();
        }
    }
}
