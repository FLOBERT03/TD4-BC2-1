using System;

namespace BiblioSynapse
{
    public class Intervenant
    {
        #region Attributs

        private string nom;
        private float tauxHoraire;

        #endregion

        #region Propriétés
        /// <summary>
        /// Retourne le taux horaire
        /// </summary>
        public float TauxHoraire { get => tauxHoraire; }

        /// <summary>
        /// Retourne le nom de l'intervenant
        /// </summary>
        public string Nom { get => nom; set => nom = value; }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Intervenant()
        {
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="iNom">Nom de l'intervenant</param>
        /// <param name="taux">Taux horaire</param>
        public Intervenant(string iNom, float taux)
        {
            nom = iNom;
            tauxHoraire = taux;
        }
        #endregion
    }
}
