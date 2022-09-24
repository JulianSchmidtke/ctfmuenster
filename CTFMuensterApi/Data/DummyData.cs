using CTFMuenster.Api.Model;
using CTFMuensterApi.Data;

public class DummyData : IDataRepository
{
    private List<Flag> MockFlags;
    private List<User> MockUsers;
    private List<UserFlag> MockUserFlags;

        private List<Tag> MockTags;

        public DummyData()
        {
            MockTags = new List<Tag>{
                new Tag(){
                            Id=new Guid("58b8d9d2-d3b5-42ec-a677-02bed9b27683"),
                            Name="Geschichte",
                            Description="Historische Orte in Muenster."
                        },
                new Tag(){
                            Id=new Guid("2af9d366-3219-4a2a-a729-36977ede3260"),
                            Name="Sport",
                            Description="Orte an denen Leute Sport machen."
                        },
                new Tag(){
                            Id=new Guid("41169a90-618d-4208-9fdf-ff180abd8e40"),
                            Name="Party",
                            Description="Die besten Orte fuer die After Hour."
                        },
                new Tag(){
                            Id=new Guid("41169a90-618d-4208-9fdf-ff180abd8e40"),
                            Name="Reverse",
                            Description="Die Alternative Spielart: von hinten nach vorne."
                        },
            };

            MockFlags = new List<Flag>
            {
                new Flag(){
                    Id=new Guid("d404eed3-5842-4d45-84b5-dce00b015dac"),
                    Description="Der Prinzipalmarkt: Münsters gute Stube.\n" +
                                "Münsters Prinzipalmarkt ist ein Stück lebendige Stadtgeschichte. " +
                                "Er erzählt vom Mittelalter, der Hanse und den alten Kaufmannsfamilien, " +
                                "die hier zum Teil immer noch ihren Geschäften nachgehen. Der Platz mit den " +
                                "charakteristischen Giebelhäusern und Bogengängen ist das traditionsreiche wirtschaftliche und politische Zentrum Münsters. \n" +
                                "Hier befindet sich das historische Rathaus mit seinem Friedenssaal. Auch zahlreiche exklusive Geschäfte und Gastronomiebetriebe haben hier ihre Adresse. \n" +
                                "Auf dem Prinzipalmarkt spielt sich ein großer Teil von Münsters Stadtleben ab: hier werden Staatsgäste empfangen und " +
                                "Feste gefeiert, hier wird flaniert, eingekauft und das Leben genossen. \n" +
                                "Dass der Prinzipalmarkt zu den schönsten Plätzen Deutschlands gehört, finden übrigens nicht nur die Münsteraner. " +
                                "2006 erreichte er in der ZDF-Sendung Unsere Besten - Die Lieblingsorte der Deutschen den vierten Platz! \n",
                    FlagName="Prinzipalmarkt",
                    Location= new Location(51.962776004909124, 7.6282566472538615),
                    ImageFileName="https://stctfmuenster.blob.core.windows.net/ctf/prinzipalmarkt.png",
                    Tags= new Tag[]{
                        MockTags.Where(x => x.Name.Equals("Geschichte")).First()
                    },
                    DateTimeStartActive = new DateTimeOffset(2022,08,23,12,0,0,TimeSpan.Zero),
                    DateTimeEndActive = new DateTimeOffset(2022,08,23,23,59,59,TimeSpan.Zero)
                },
                new Flag(){
                    Id=new Guid("76d4fc1a-643c-4ec7-a876-a14cdec0980c"),
                    Description="Der Buddenturm (auch Pulverturm) ist der älteste noch erhaltene Teil der " +
                                "ehemaligen Stadtbefestigung der westfälischen Stadt Münster. \n" +
                                "Der Buddenturm wurde um 1150 als Wehrturm errichtet. Die ursprüngliche Höhe " +
                                "etrug 20 m. Kurz vor der Herrschaft der Täufer diente er im Jahre 1533 zusätzlich " +
                                "ls Gefängnis und ab 1598 als Pulverturm. Ab 1629 folgte der Anbau eines 10 m hohen, " +
                                "sechseckigen Treppenturmes an der Westseite sowie der Einbau eines Gewölbes bis auf " +
                                "die Höhe des Treppenturmes. Im 18. Jahrhundert wurde dieser weiter aufgestockt und " +
                                "reichte daraufhin bis zum Dach.\n " +
                                "Als die Stadtbefestigung zwischen 1764 und 1767 abgebrochen wurde, blieb der Turm " +
                                "stehen, da er auch als Pulverturm diente und diese Funktion auch weiter erfüllte. " +
                                "Nachdem er in der Zeit danach ab dem Jahre 1771 zusammen mit dem nahegelegenen Zwinger " +
                                "auch als Gefängnis diente, kaufte die Stadt den Turm im Jahre 1879 vom Militär für 3620 Mark ab. " +
                                "Anschließend stockte die Stadt ihn um 20 m auf bei gleichzeitigem Abbau des Treppenturmes, " +
                                "um ihn als Wasserturm zu nutzen. Dazu wurde ein 500 m³ fassender Wassertank eingebaut " +
                                "und das Ziegeldach durch eine neugotische Zinnenkrone ersetzt. An diese Funktion erinnern " +
                                "noch immer eine erhaltene Messskala sowie die Fallrohre im Inneren des Turms. ",
                    FlagName="Buddenturm",
                    Location= new Location(51.96626699838519, 7.623065882679778),
                    ImageFileName="https://stctfmuenster.blob.core.windows.net/ctf/buddenturm.png",
                    Tags= new Tag[]{
                        MockTags.Where(x => x.Name.Equals("Geschichte")).First()
                    },
                    DateTimeStartActive = new DateTimeOffset(2022,08,22,0,0,0,TimeSpan.Zero),
                    DateTimeEndActive = new DateTimeOffset(2022,08,22,23,59,59,TimeSpan.Zero)
                },
                new Flag(){
                    Id=new Guid("ba529460-c0a1-428d-9239-9ae3442e18fb"),
                    Description="Davidwache -– Das Lokal\n" +
                                "Benannt nach dem berühmtesten Polizeirevier der Welt," +
                                "befindet sich die Davidwache seit 12 Jahren am Eingang" +
                                "zur Jüdefelder Straße. Unser Leibgetränk ist Long Island" +
                                "und unser Kulthit die Promenade. Am besten kommt ihr" +
                                "einfach mal auf das eine oder andere Getränk vorbei." +
                                "Aber nicht schneller, als es die Polizei erlaubt.",
                    FlagName="Davidwache",
                    Location= new Location(51.96646017686706, 7.6182496299172575),
                    ImageFileName="https://stctfmuenster.blob.core.windows.net/ctf/davidwache.png",
                    Tags= new Tag[]{
                        MockTags.Where(x => x.Name.Equals("Party")).First()
                    },
                    DateTimeStartActive = new DateTimeOffset(2022,08,20,0,0,0,TimeSpan.Zero),
                    DateTimeEndActive = new DateTimeOffset(2022,08,20,23,59,59,TimeSpan.Zero)
                },
                new Flag(){
                    Id=new Guid("1b2eda74-1053-495d-a88d-748fb093aa70"),
                    Description="Das Schloss Münster darf bei einer Besichtigung Münsters natürlich nicht fehlen. " +
                                "Es ist ein ausgesprochen guter Startpunkt zu einem Bummel durch die Straßen der Stadt. " +
                                "In unmittelbarer Nähe befinden sich zahlreiche Sehenswürdigkeiten für deren Besuch " +
                                "Sie etwas Zeit einplanen sollten. " +
                                "Von der fürstbischöflichen Residenz zur Universität\n " +
                                "Das Schloss Münster war bis 1803 fürstbischöfliche Residenz. Der Architekt Johann Conrad Schlaun " +
                                "errichtete den barocken Bau für Münsters vorletzten Fürstbischof Maximilian Friedrich von Königsegg-Rothenfels. " +
                                "Die 91 Meter lange Dreiflügelanlage mit fünfachsigem Mittelrisalit ist durch die Verwendung von rotem Backstein " +
                                "und hellem Sandstein elegant gestaltet. 1945 wurde das Schloss total zerbombt, zwischen 1947 und 1953 wurde " +
                                "es nach alten Plänen zumindest in seiner äußeren Gestalt wiedererrichtet.\n " +
                                "Ein Schloss wird zum Wissenszentrum\n " +
                                "Heute ist es Sitz der Verwaltung der Universität Münster. Im Schlossgarten hat das Ende des 19. Jahrhunderts " +
                                "errichtete Institut für Botanik des Fachbereichs Biologie der Uni Münster seinen Sitz. Gleichzeitig befindet " +
                                "sich dort der Botanische Garten des Instituts, der unregelmäßig zu öffentlichen Führungen einlädt.\n " +
                                "Das Lebensgefühl der Stadt wird deutlich von der Universität geprägt. Die zahllosen Studenten bevölkern vor " +
                                "allem bei gutem Wetter die Biergärten und Plätze der Stadt. Zu diesem entspannten Lebensstil passt das " +
                                "Fahrrad als Hauptverkehrsmitteln natürlich ganz besonders. Der Schlossplatz ist ein beliebter Ort für " +
                                "Veranstaltungen. Das Turnier der Sieger oder der Send, Münsters großes Volksfest, haben hier ihre Heimat. ",
                    FlagName="Schloss",
                    Location= new Location(51.963522387472324, 7.614137158901378),
                    ImageFileName="https://stctfmuenster.blob.core.windows.net/ctf/schloss.png",
                    Tags= new Tag[]{
                        MockTags.Where(x => x.Name.Equals("Geschichte")).First()
                    },
                    DateTimeStartActive = new DateTimeOffset(2022,08,19,0,0,0,TimeSpan.Zero),
                    DateTimeEndActive = new DateTimeOffset(2022,08,19,23,59,59,TimeSpan.Zero)
                },
                new Flag(){
                    Id=new Guid("f479d87e-68dd-4b1c-97ca-f8157aac90ef"),
                    Description="Münsters Stadthafen hat sich vom Güterumschlagplatz zum Kreativkai entwickelt. " +
                                "Häuser, Kunst, Kultur, Restaurants und Szeneclubs sorgen dafür, dass hier rund " +
                                "um die Uhr immer eine Menge los ist. \n" +
                                "Die Mischung aus umgebauten Speicherhäusern und moderner Architektur machen den " +
                                "besonderen Reiz von Münsters Stadthafen aus. Hier haben die Kreativen ihr " +
                                "Quartier gefunden: Werbeagenturen, Architekturbüros und Verlage wie der Coppenrath " +
                                "Verlag mit seinem Hasen Felix haben sich hier angesiedelt.\n " +
                                "Wer tagsüber Hafenluft schnuppern möchte, dem empfiehlt sich ein Besuch der " +
                                "Kunsthalle Münster. Die Ausstellungshalle befindet sich in einem umgebauten " +
                                "Speicherhaus, das auch noch 30 Künstlerateliers beheimatet. Anschließend genießt " +
                                "man in einem der zahlreichen Cafés oder Restaurants den Blick aufs Wasser. \n" +
                                "Gut gestärkt kann es dann weitergehen. Wie wärs am Abend mit einem Kinobesuch " +
                                "oder einem Abend im Wolfgang Borchert Theater? Sie mögen lieber Live-Jazz? " +
                                "Dann ist der Hot Jazz Club bestimmt etwas für Sie. Bei gutem Wetter ist der " +
                                "Hafen ein großes Open-Air-Spektakel, bei dem man seinen Longdrink im Liegestuhl " +
                                "unter Palmen genießen kann. Und für all diejenigen, die gerne mal eine Nacht " +
                                "durchtanzen, gibt es rund um den Stadthafen ausgiebig Gelegenheit dazu. \n" +
                                "Einer der Höhepunkte in Münsters Veranstaltungskalender ist das einmal im " +
                                "Jahr stattfindende Hafenfest. Drei Tage (und Nächte) lang sind das Hafenbecken " +
                                "und die angrenzende Promenade zur Bühne für Musiker, Aktionen und sportliche " +
                                "Aktivitäten mit einem bunten Kinder- und Familienprogramm.\n",
                    FlagName="Hafen",
                    Location= new Location(51.95130983077973, 7.638806055037238),
                    ImageFileName="https://stctfmuenster.blob.core.windows.net/ctf/hafen.png",
                    Tags= new Tag[]{
                        MockTags.Where(x => x.Name.Equals("Party")).First()
                    },
                    DateTimeStartActive = new DateTimeOffset(2022,09,22,0,0,0,TimeSpan.Zero),
                    DateTimeEndActive = new DateTimeOffset(2022,09,26,23,59,59,TimeSpan.Zero)
                },
                new Flag(){
                    Id=new Guid("5b6b9b4e-e58c-408a-91b3-bf8504978f38"),
                    Description="Der Flugplatz Münster-Handorf ist ein ehemaliger Verkehrsflugplatz, " +
                                "Fliegerhorst der Luftwaffe und Nike-Abwehrstellung im Stadtteil Handorf " +
                                "der westfälischen Stadt Münster. Er dient heute als Standortübungsplatz.\n " +
                                "Die Geschichte des Flugplatzes geht auf das Jahr 1934 zurück. Als der " +
                                "damalige Flugplatz der Stadt Münster auf der Loddenheide zu klein wurde " +
                                "und den Anforderungen der Luftfahrt nicht mehr gewachsen war, begann die " +
                                "Suche nach einem geeigneten Gelände für den Neubau eines größeren Flugplatzes. " +
                                "Die Wahl fiel auf ein Gelände im Bereich der zu jener Zeit noch selbständigen " +
                                "Gemeinde Handorf, einige Kilometer östlich von Münster. Nachdem im November 1934 " +
                                "die Entscheidung zum Bau getroffen wurde, begannen die Bauarbeiten im Jahr 1935 " +
                                "durch die eigens gegründete Flughafen-GmbH Münster-Handorf. Das Richtfest fand " +
                                "im September 1936 statt, die Bauarbeiten selbst waren am 1. April 1937 abgeschlossen. " +
                                "Bereits drei Tage später, am 4. April 1937, wurde die Fluglinie Münster – Berlin eröffnet.\n " +
                                "Der Flugplatz selbst bestand aus zwei Teilen: Einem militärischen Teil in der " +
                                "nordwestlichen Ecke des Platzes in Richtung Handorf gelegen und einem weitaus " +
                                "kleineren zivilen Teil in der südöstlichen Ecke, dem Ort Telgte zugewandt. Zum " +
                                "zivilen Teil gehörten ein Abfertigungsgebäude, ein Restaurant, die Flughafenverwaltung sowie eine Flugzeughalle. " +
                                "Erhalten gebliebene Unterkunftsgebäude der niederländischen Nike-Stellung am Südrand des Geländes werden durch " +
                                "das Technische Hilfswerk genutzt. Unmittelbar benachbart betreibt das Institut der Feuerwehr Nordrhein-Westfalen " +
                                "sein Übungsgelände.\n ",
                    FlagName="Flugplatz Münster-Handorf",
                    Location= new Location(51.995277777778, 7.7319444444444),
                    ImageFileName="https://stctfmuenster.blob.core.windows.net/ctf/handorf-flugplatz.png",
                    Tags= new Tag[]{
                        MockTags.Where(x => x.Name.Equals("Geschichte")).First()
                    },
                    DateTimeStartActive = new DateTimeOffset(2022,09,22,0,0,0,TimeSpan.Zero),
                    DateTimeEndActive = new DateTimeOffset(2022,09,22,23,59,59,TimeSpan.Zero)
                },
                new Flag(){
                    Id=new Guid("d87c0120-31ba-4a77-8af5-417729362f75"),
                    Description="Der St.-Paulus-Dom ist eine römisch-katholische Kirche in Münster " +
                                "unter dem Patrozinium des Apostels Paulus. Die Kathedrale des Bistums " +
                                "Münster zählt zu den bedeutendsten Kirchenbauten in Münster und ist " +
                                "neben dem historischen Rathaus eines der Wahrzeichen der Stadt. " +
                                "Verwaltet wird der Dom vom Domkapitel Münster.\n " +
                                "Der Dom steht im Herzen der Stadt auf einer kleinen Anhöhe, Horsteberg " +
                                "genannt, die halbkreisförmig durch den Straßenzug von Spiekerhof, Roggenmarkt, " +
                                "Prinzipalmarkt und Rothenburg umgrenzt wird. Dieses Gebiet, samt Domplatz und " +
                                "angrenzenden Gebäudeflächen, bildete die alte Domburg und Domimmunität. Für " +
                                "diesen Bezirk hat der Dom heute die " +
                                "Funktion einer Pfarrkirche. Westlich des Doms liegt die Kettelersche " +
                                "Doppelkurie: das heutige Bischofspalais sowie eines der ehemaligen Kuriengebäude " +
                                "mit der heutigen Domverwaltung. An der Stelle der weiteren, ehemals um den " +
                                "Domplatz befindlichen Kuriengebäude stehen unter anderem Gebäude der Universität " +
                                "Münster, der Bezirksregierung Münster und das LWL-Landesmuseum für Kunst und Kulturgeschichte.\n " +
                                "Die Kathedrale hatte zwei Vorgängerbauten: Der erste Dom (sogenannter Ludgerus-Dom, 805–1377) " +
                                "stand nördlich des heutigen Doms; der zweite Dom wurde im 10. oder 11. Jahrhundert " +
                                "erbaut und mit Errichtung des dritten, des heutigen Doms in den Jahren 1225–1264 " +
                                "abgerissen. Das mächtige Westwerk mit seinen nahezu identischen Türmen war bereits " +
                                "um das Jahr 1192 an den zweiten Dom angebaut worden und wurde in den dritten Dom " +
                                "einbezogen. Der St.-Paulus-Dom vereinigt Stilelemente der Romanik mit dem Westwerk, " +
                                "das heißt mit dem Alten Chor und den Westtürmen, und der Gotik im angrenzenden Basilika-Bau, mit den beiden Querschiffen, dem Langhaus, dem Hochchor und dem Kapellenkranz.\n " +
                                "Im Dom befindet sich die Grabstätte des ehemaligen Bischofs von Münster, " +
                                "Clemens August Graf von Galen, der kurz vor seinem Tod im Jahre 1946 zum Kardinal " +
                                "erhoben worden war und 2005 von Papst Benedikt XVI. seliggesprochen wurde.\n " +
                                "Mit der (jeweiligen) Weihe wurde jeder Dombau zur Bischofskirche des Bistums Münster. " +
                                "Daneben hatten die einzelnen Dombauten, zumindest zeitweise, zusätzliche Funktionen.\n " +
                                "Der erste karolingische Dom war gleichzeitig die Stiftskirche für die nach der Regel " +
                                "des heiligen Chrodegangs lebenden Brüder des von Liudger gegründeten Klosters.\n " +
                                "Jeder Dombau hatte zudem die Funktion einer Pfarrkirche. Der Pfarrbezirk umfasste " +
                                "ursprünglich ganz Münster. Nachdem in Münster weitere Pfarrbezirke gegründet worden " +
                                "waren, wurde der Pfarrbezirk des Doms im Jahre 1090 auf die alte Domburg und Domimmunität beschränkt.\n " +
                                "In der ersten Hälfte des 13. Jahrhunderts, in der der dritte (heutige) Dom erbaut wurde, " +
                                "wurde auf dem Domplatz die Kirche St. Jacobi errichtet. Mit der Fertigstellung dieser Kirche " +
                                "verlor der im Bau befindliche Dom seine Funktion als Pfarrkirche gänzlich. Seit dem Abriss der " +
                                "Jakobikirche im Jahre 1812 ist der Dom wieder Pfarrkirche für den oben genannten begrenzten Bezirk.\n ",
                    FlagName="St.-Paulus-Dom",
                    Location= new Location(51.96296072682899, 7.625782327779225),
                    ImageFileName="https://stctfmuenster.blob.core.windows.net/ctf/paulus-dom.png",
                    Tags= new Tag[]{
                        MockTags.Where(x => x.Name.Equals("Reverse")).First()
                    },
                    DateTimeStartActive = new DateTimeOffset(2022,09,24,0,0,0,TimeSpan.Zero),
                    DateTimeEndActive = new DateTimeOffset(2022,09,24,23,59,59,TimeSpan.Zero)
                }
            };

        MockUsers = new List<User>
            {
                new User(){
                    Id=new Guid("e59871b2-5970-4f04-b1cd-42a0796a5279"),
                    UserName="Annabelle"},
                new User(){
                    Id=new Guid("62abdae3-6942-4460-9d47-06cb953de8fb"),
                    UserName="Bertha"},
                new User(){
                    Id=new Guid("90f2b715-b434-4362-b845-15397fa0a1dc"),
                    UserName="Christian"},
                new User(){
                    Id=new Guid("2d1782d9-59de-4cff-9014-e79045cabfc2"),
                    UserName="Manfred"},
                new User(){
                    Id=new Guid("a59ed73d-20be-458d-bd31-da4aabbeb1d2"),
                    UserName="Katharina"},
                new User(){
                    Id=new Guid("b25314c6-d399-4827-a9c3-ac403abaabd3"),
                    UserName="Olaf"},
                new User(){
                    Id=new Guid("000c26b2-a9cc-49bf-9705-fffbb47e4cee"),
                    UserName="Wladimir"},
                new User(){
                    Id=new Guid("90d31f13-0fcf-428a-a8e4-65a69f9cc250"),
                    UserName="Boris"},
                new User(){
                    Id=new Guid("216e480e-3664-4d8c-b5a6-a358edc4cf53"),
                    UserName="Donald"},

            };

        MockUserFlags = new List<UserFlag>
            {
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[0].Id,
                    FlagId=MockFlags[0].Id,
                    DateTimeCollected = new DateTimeOffset(2022,08,23,13,0,0,TimeSpan.Zero),
                    Score=1000},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[1].Id,
                    FlagId=MockFlags[0].Id,
                    DateTimeCollected = new DateTimeOffset(2022,08,23,14,0,0,TimeSpan.Zero),
                    Score=950},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[2].Id,
                    FlagId=MockFlags[0].Id,
                    DateTimeCollected = new DateTimeOffset(2022,08,23,15,0,0,TimeSpan.Zero),
                    Score=900},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[3].Id,
                    FlagId=MockFlags[0].Id,
                    DateTimeCollected = new DateTimeOffset(2022,08,23,16,0,0,TimeSpan.Zero),
                    Score=850},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[4].Id,
                    FlagId=MockFlags[0].Id,
                    DateTimeCollected = new DateTimeOffset(2022,08,23,17,0,0,TimeSpan.Zero),
                    Score=800},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[5].Id,
                    FlagId=MockFlags[0].Id,
                    DateTimeCollected = new DateTimeOffset(2022,08,23,18,0,0,TimeSpan.Zero),
                    Score=750},
                


                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[4].Id,
                    FlagId=MockFlags[5].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,22,12,0,0,TimeSpan.Zero),
                    Score=1000},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[5].Id,
                    FlagId=MockFlags[5].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,22,12,0,0,TimeSpan.Zero),
                    Score=950},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[6].Id,
                    FlagId=MockFlags[5].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,22,12,0,0,TimeSpan.Zero),
                    Score=900},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[7].Id,
                    FlagId=MockFlags[5].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,22,12,0,0,TimeSpan.Zero),
                    Score=850},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[8].Id,
                    FlagId=MockFlags[5].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,22,12,0,0,TimeSpan.Zero),
                    Score=800},

                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[5].Id,
                    FlagId=MockFlags[6].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,24,11,0,0,TimeSpan.Zero),
                    Score=1000},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[4].Id,
                    FlagId=MockFlags[6].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,24,11,0,0,TimeSpan.Zero),
                    Score=950},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[3].Id,
                    FlagId=MockFlags[6].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,24,11,0,0,TimeSpan.Zero),
                    Score=900},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[2].Id,
                    FlagId=MockFlags[6].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,24,11,0,0,TimeSpan.Zero),
                    Score=850},
            };

        }

    public UserFlag AddUserFlag(UserFlag userFlag)
    {
        MockUserFlags.Add(userFlag);
        return userFlag;
    }

    public IEnumerable<Flag> GetFlags()
    {
        return MockFlags;
    }

    public IEnumerable<UserFlag> GetUserFlags()
    {
        return MockUserFlags;
    }

    public IEnumerable<User> GetUsers()
    {
        return MockUsers;
    }

    public Flag AddFlag(Flag flag)
    {
        MockFlags.Add(flag);
        return flag;
    }
}
