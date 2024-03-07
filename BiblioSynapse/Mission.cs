using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioSynapse
{
    public class Mission
    {
        #region Attributs

        private string nom;
        private string description;
        private int nbHeuresPrevues;
        private Intervenant executant;
        private Dictionary<DateTime, int> releveHoraire;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Mission()
        {

        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="mNom">Nom de la mission</param>
        /// <param name="mDescription">Description de la mission</param>
        /// <param name="nbHeures">Nombre d'heures prévues</param>
        /// <param name="unExecutant">Intervenant</param>
        public Mission(string mNom, string mDescription, int nbHeures, Intervenant unExecutant)
        {
            nom = mNom;
            description = mDescription;
            nbHeuresPrevues = nbHeures;
            executant = unExecutant;

        }
        #endregion

        #region Accesseurs

        /// <summary>
        /// Retourne le relevé horaire
        /// </summary>
        /// <returns></returns>
        public Dictionary<DateTime, int> ReleveHoraire { get => releveHoraire; }

        /// <summary>
        /// Retourne l'intervenant
        /// </summary>
        /// <returns></returns>
        public Intervenant Executant { get => executant; set => executant = value; }
        #endregion

        #region Méthodes

        /// <summary>
        /// Ajoute au relevé une date et un nombre d'heures
        /// </summary>
        /// <param name="jour">Date</param>
        /// <param name="nbHeures">Nombre d'heures</param>
        public void ajoutReleve(DateTime jour, int nbHeures)
        {

            //A définir

        }

        /// <summary>
        /// retourne le nombre d'heures réellement effectuées
        /// </summary>
        /// <returns></returns>
        public int nbHeuresEffectuees()
        {
            //A définir
        }

        /// <summary>
        /// Affiche le relevé horaire
        /// </summary>
        public void afficherReleveHoraire()
        {
            //A définir
        }
        #endregion
    }
}
