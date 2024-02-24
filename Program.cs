namespace myProject
{
    class Portfolio
    {
        //3 private fields
        private string _Category;
        private string _Description;
        private List<string> _Work;

        //default constructor
        public Portfolio()
        {
            _Category = "";
            _Description = "";
            _Work = new List<string>();
        }

        //parameterized constructor
        public Portfolio(string category, string description, List<string> work)
        {
            _Category = category;
            _Description = description;
            _Work = work;
        }

        //get and set methods for each field
        public string GetCategory() => _Category;
        public void SetCategory(string category) => _Category = category;

        public string Description => _Description;
        public void SetDescription(string description) => _Description = description;

        public List<string> GetWork() => _Work;
        public void SetWork(List<string> work) => _Work = work;

        static void Main(string[] args)
        {
            //in Main method, add 2 objects w/ default constructor 
            Portfolio printmaking = new Portfolio();
            Portfolio sketches = new Portfolio();

            // Add some items to the default objects
            printmaking.SetCategory("Printmaking");
            printmaking.SetDescription("Prints created in summer 2023 Printmaking 1 class.");
            printmaking.SetWork(new List<string> { "'Summer Scene' - Monoprint'", "'Color Cascade' - Monoprint", "'BlowingSmoke' - Linocut", "'Spicy' - Continuous Line Etching", "'Blowing Smoke' - Screen Print" });
            sketches.SetCategory("Sketches");
            sketches.SetDescription("Sketches created in Drawing 1, Printmaking 1, and Materials and Techniques classes.");
            sketches.SetWork(new List<string> { "'Blowing Smoke' - Initial Sketch", "'Little House' - Initial Sketch", "'Artichokes' - Initial Sketch", "'Value Study' - Ink Sketch" });

            //in Main method, add 2 objects w/ parameterized constructor
            Portfolio twoD_Art = new Portfolio("2-D Art", "Art created in fall 2022 2-D Art class", new List<string> { "'Circle of Emotion' - Abstract Representation - Mixed Media", "'Peacock Prism' - Tesselation", "'Abbey Road' - Triptych - Black and White Final" });
            Portfolio digitalArt = new Portfolio("Digital Art", "Art created using various digital tools", new List<string> { "'Spicy' - Digital Painting", "'Spicy' Continuous Line - Vector Art", "'Mike the Headless Chicken Festival' - Poster Design ", "'Retro Virus' - T-Shirt Mockup", "'Miss Myrtle's Magic Medicinal Cocaine Drops' - Packaging Design" });
            Portfolio paintings = new Portfolio("Paintings", "Oil paintings created in Painting 1 class, and Watercolor Paintings from Materials & Techniques class", new List<string> { "'Still Life I' - Oil Painting", "'Still Life II' - Oil Painting", "'Identity' - Oil Painting", "'Scream' - Appropriation - Oil Painting", "'Blowing Smoke' - Oil Painting", "'Little House' - Ink Wash", "'Artichokes' - Watercolor" });
            Portfolio webPages = new Portfolio("Web Pages", "Web pages created using HTML, CSS, and JavaScript", new List<string> { "https://nmc.augusoft.net//info/landing/Work-Career", "https://nmc.augusoft.net//info/landing/youth-programs", "https://nmc.augusoft.net/index.cfm?fuseaction=1060", "https://nmc.augusoft.net//info/landing/advisory-board" });

            //after objects are created, print out object details to the console
            Console.WriteLine("Portfolio Categories & Details: ");
            Console.WriteLine();
            displayPortfolio(printmaking);
            displayPortfolio(sketches);
            displayPortfolio(digitalArt);
            displayPortfolio(paintings);
            displayPortfolio(webPages);

        }

        private static void printDivider(Portfolio portfolio)
        {
            Console.WriteLine($"******** {portfolio.GetCategory()} ********");
        }

        static void displayPortfolio(Portfolio portfolio)
        {
            printDivider(portfolio);
            Console.WriteLine();
            Console.WriteLine($"Category: {portfolio.GetCategory()}");

            Console.WriteLine($"Description: {portfolio.Description}");

            Console.WriteLine("Work: ");
            foreach (string work in portfolio.GetWork())
            {
                Console.WriteLine(work);
            }
            Console.WriteLine();
            Console.WriteLine();

        }

    }


}


