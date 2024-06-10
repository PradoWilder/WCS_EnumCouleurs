using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumCouleurs
{
    // Définition de l'énumération pour les couleurs
    public enum Couleur
    {
        ROUGE,
        BLEU,
        VERT,
        JAUNE
    }

    // Classe User avec Nom, Prenom et Couleur
    public class User
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Couleur Couleur { get; set; }

        public User(string nom, string prenom, Couleur couleur)
        {
            Nom = nom;
            Prenom = prenom;
            Couleur = couleur;
        }

        public override string ToString()
        {
            return $"Prénom : {Prenom}\nNom : {Nom}\nCouleur : {CouleurToString(Couleur)}\n";
        }

        private string CouleurToString(Couleur couleur)
        {
            return couleur switch
            {
                Couleur.ROUGE => "Rouge",
                Couleur.BLEU => "Bleu",
                Couleur.VERT => "Vert",
                Couleur.JAUNE => "Jaune",
                _ => "Inconnu"
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instanciation de la liste d'utilisateurs
            var utilisateurs = new List<User>
            {
                new User("Doe", "John", Couleur.ROUGE),
                new User("Smith", "Jane", Couleur.BLEU),
                new User("Dupont", "Pierre", Couleur.VERT),
                new User("Martin", "Anne", Couleur.JAUNE),
                new User("Brown", "Bob", Couleur.ROUGE),
                new User("White", "Alice", Couleur.BLEU)
            };

            // Affichage des informations des utilisateurs
            foreach (var utilisateur in utilisateurs)
            {
                Console.WriteLine(utilisateur);
            }

            // Comptage et affichage du nombre d'utilisateurs par couleur
            var couleurs = Enum.GetValues(typeof(Couleur)).Cast<Couleur>();
            foreach (var couleur in couleurs)
            {
                int count = utilisateurs.Count(u => u.Couleur == couleur);
                Console.WriteLine($"{couleur} : {count} utilisateurs");
            }
        }
    }
}
