using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioSynapse
{
    public class Projet
    {
        #region Attributs
        private string nom;
        private DateTime debut;
        private DateTime fin;
        private float prixFactureMo;
        private List<Mission> missions;
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Projet()
        {
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="pNom">Nom du projet</param>
        /// <param name="dDebut">Date de début</param>
        /// <param name="dFin">Date de fin</param>
        /// <param name="prix">Prix facturé</param>
        public Projet(string pNom, DateTime dDebut, DateTime dFin, float prix)
        {
            nom = pNom;
            debut = dDebut;
            fin = dFin;
            prixFactureMo = prix;
            missions = new List<Mission>();
        }
        #endregion

        #region Méthodes

        /// <summary>
        /// Calcul du coût cumulé de la main d'oeuvre
        /// </summary>
        /// <returns></returns>
        private float cumulCoutMO()
        {
            //A définir
        }

        /// <summary>
        /// Affecter une mission au projet
        /// </summary>
        /// <param name="uneMission">Mission</param>
        public void affecterMission(Mission uneMission)
        {
            missions.Add(uneMission);
        }

        /// <summary>
        /// Calcul de la marge brute du projet
        /// </summary>
        /// <returns></returns>
        public float margeBruteCourante()
        {
            //A définir
        }
        #endregion
    }
}
