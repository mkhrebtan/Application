using Domain.Models;

namespace Persistence.SampleData;

internal static class DatabaseSeeder
{
    private const string _preHashedPassword = "$2a$11$V2cYAlIQUgz1cAHT9elmteBzF.zj.Zc4pIIjRBHojluqcJKLMbbue";

    private static readonly Guid[] VisitorIds =
    [
        Guid.Parse("10000000-0000-0000-0000-000000000001"),
        Guid.Parse("10000000-0000-0000-0000-000000000002"),
        Guid.Parse("10000000-0000-0000-0000-000000000003"),
        Guid.Parse("10000000-0000-0000-0000-000000000004"),
        Guid.Parse("10000000-0000-0000-0000-000000000005"),
        Guid.Parse("10000000-0000-0000-0000-000000000006"),
        Guid.Parse("10000000-0000-0000-0000-000000000007"),
        Guid.Parse("10000000-0000-0000-0000-000000000008"),
        Guid.Parse("10000000-0000-0000-0000-000000000009"),
        Guid.Parse("10000000-0000-0000-0000-000000000010"),
        Guid.Parse("10000000-0000-0000-0000-000000000011"),
        Guid.Parse("10000000-0000-0000-0000-000000000012"),
        Guid.Parse("10000000-0000-0000-0000-000000000013"),
        Guid.Parse("10000000-0000-0000-0000-000000000014"),
        Guid.Parse("10000000-0000-0000-0000-000000000015"),
        Guid.Parse("10000000-0000-0000-0000-000000000016"),
        Guid.Parse("10000000-0000-0000-0000-000000000017"),
        Guid.Parse("10000000-0000-0000-0000-000000000018"),
        Guid.Parse("10000000-0000-0000-0000-000000000019"),
        Guid.Parse("10000000-0000-0000-0000-000000000020"),
        Guid.Parse("10000000-0000-0000-0000-000000000021"),
        Guid.Parse("10000000-0000-0000-0000-000000000022"),
        Guid.Parse("10000000-0000-0000-0000-000000000023"),
        Guid.Parse("10000000-0000-0000-0000-000000000024"),
        Guid.Parse("10000000-0000-0000-0000-000000000025"),
        Guid.Parse("10000000-0000-0000-0000-000000000026"),
        Guid.Parse("10000000-0000-0000-0000-000000000027"),
        Guid.Parse("10000000-0000-0000-0000-000000000028"),
        Guid.Parse("10000000-0000-0000-0000-000000000029"),
        Guid.Parse("10000000-0000-0000-0000-000000000030"),
        Guid.Parse("10000000-0000-0000-0000-000000000031"),
        Guid.Parse("10000000-0000-0000-0000-000000000032"),
        Guid.Parse("10000000-0000-0000-0000-000000000033"),
        Guid.Parse("10000000-0000-0000-0000-000000000034"),
        Guid.Parse("10000000-0000-0000-0000-000000000035"),
        Guid.Parse("10000000-0000-0000-0000-000000000036"),
        Guid.Parse("10000000-0000-0000-0000-000000000037"),
        Guid.Parse("10000000-0000-0000-0000-000000000038"),
        Guid.Parse("10000000-0000-0000-0000-000000000039"),
        Guid.Parse("10000000-0000-0000-0000-000000000040"),
        Guid.Parse("10000000-0000-0000-0000-000000000041"),
        Guid.Parse("10000000-0000-0000-0000-000000000042"),
        Guid.Parse("10000000-0000-0000-0000-000000000043"),
        Guid.Parse("10000000-0000-0000-0000-000000000044"),
        Guid.Parse("10000000-0000-0000-0000-000000000045"),
        Guid.Parse("10000000-0000-0000-0000-000000000046"),
        Guid.Parse("10000000-0000-0000-0000-000000000047"),
        Guid.Parse("10000000-0000-0000-0000-000000000048"),
        Guid.Parse("10000000-0000-0000-0000-000000000049"),
        Guid.Parse("10000000-0000-0000-0000-000000000050"),
    ];

    internal static readonly User[] Users =
    {
        User.Create(
            "John",
            "Doe",
            "john.doe@example.com",
            _preHashedPassword).Value,
        User.Create(
            "Jane",
            "Smith",
            "jane.smith@example.com",
            _preHashedPassword).Value,
        User.Create(
            "Alice",
            "Johnson",
            "alice.johnson@example.com",
            _preHashedPassword).Value,
    };

    internal static readonly Tag[] Tags =
    [
        new("Technology"),
        new("Art"),
        new("Health"),
        new("Education"),
        new("Networking"),
        new("Music"),
        new("Sports"),
        new("Food & Drink"),
        new("Business"),
        new("Travel"),
    ];

    internal static Event[] Events(User[] users)
    {
        return
        [
            // Future events
            Event.Create(
                users[0].Id,
                "Community Meetup",
                "A meetup for community members.",
                DateTime.UtcNow.AddDays(1),
                "Community Center",
                true).Value,
            Event.Create(
                users[1].Id,
                "Tech Conference",
                "Annual technology conference.",
                DateTime.UtcNow.AddDays(7),
                "Convention Hall",
                true,
                50).Value,
            Event.Create(
                users[2].Id,
                "Art Workshop",
                "A workshop for art enthusiasts.",
                DateTime.UtcNow.AddDays(14),
                "Art Studio",
                true).Value,
            Event.Create(
                users[0].Id,
                "Private Dinner Party",
                "An exclusive dinner party for close friends.",
                DateTime.UtcNow.AddDays(3),
                "Home",
                false).Value,
            Event.Create(
                users[1].Id,
                "Board Game Night",
                "Private board game session.",
                DateTime.UtcNow.AddDays(5),
                "Game Cafe",
                false,
                8).Value,
            Event.Create(
                users[2].Id,
                "Yoga Class",
                "Morning yoga session for all levels.",
                DateTime.UtcNow.AddDays(2),
                "Wellness Center",
                true,
                20).Value,
            Event.Create(
                users[0].Id,
                "Family Reunion",
                "Annual family gathering.",
                DateTime.UtcNow.AddDays(30),
                "Family Home",
                false,
                25).Value,
            Event.Create(
                users[1].Id,
                "City Marathon",
                "Annual city-wide marathon event.",
                DateTime.UtcNow.AddDays(60),
                "City Streets",
                true).Value,
            Event.Create(
                users[2].Id,
                "Book Club Meeting",
                "Monthly book club discussion.",
                DateTime.UtcNow.AddDays(10),
                "Library Private Room",
                false).Value,
            Event.Create(
                users[0].Id,
                "Cooking Workshop",
                "Learn to cook Italian cuisine.",
                DateTime.UtcNow.AddDays(12),
                "Culinary Institute",
                true,
                15).Value,
            Event.Create(
                users[1].Id,
                "Investment Seminar",
                "Private investment strategy seminar.",
                DateTime.UtcNow.AddDays(20),
                "Financial Center",
                false,
                30).Value,
            Event.Create(
                users[2].Id,
                "Music Festival",
                "Open air music festival with multiple bands.",
                DateTime.UtcNow.AddDays(45),
                "Park Amphitheater",
                true).Value,
            Event.Create(
                users[0].Id,
                "Wine Tasting Evening",
                "Exclusive wine tasting for connoisseurs.",
                DateTime.UtcNow.AddDays(8),
                "Private Wine Cellar",
                false).Value,
            Event.Create(
                users[1].Id,
                "Photography Masterclass",
                "Professional photography workshop.",
                DateTime.UtcNow.AddDays(15),
                "Photography Studio",
                true,
                12).Value,
            Event.Create(
                users[2].Id,
                "Corporate Team Building",
                "Private team building activities.",
                DateTime.UtcNow.AddDays(18),
                "Adventure Park",
                false,
                40).Value,
            Event.Create(
                users[0].Id,
                "Street Food Festival",
                "Explore diverse street food from around the world.",
                DateTime.UtcNow.AddDays(25),
                "Downtown Plaza",
                true).Value,
            Event.Create(
                users[1].Id,
                "Poetry Reading Circle",
                "Intimate poetry reading and discussion.",
                DateTime.UtcNow.AddDays(6),
                "Cozy Bookshop",
                false).Value,
            Event.Create(
                users[2].Id,
                "Blockchain Summit",
                "Learn about blockchain technology and cryptocurrency.",
                DateTime.UtcNow.AddDays(35),
                "Tech Hub",
                true,
                100).Value,
            Event.Create(
                users[0].Id,
                "Bachelor Party",
                "Private celebration for the groom-to-be.",
                DateTime.UtcNow.AddDays(9),
                "Resort",
                false,
                15).Value,
            Event.Create(
                users[1].Id,
                "Charity Walk",
                "Community charity walk for local hospital.",
                DateTime.UtcNow.AddDays(40),
                "City Park Trail",
                true).Value,
            Event.Create(
                users[2].Id,
                "Exclusive Product Launch",
                "Private launch event for new product line.",
                DateTime.UtcNow.AddDays(22),
                "Luxury Hotel Ballroom",
                false).Value,
            Event.Create(
                users[0].Id,
                "Dance Class Beginner",
                "Learn salsa dancing from scratch.",
                DateTime.UtcNow.AddDays(4),
                "Dance Studio",
                true,
                25).Value,
            Event.Create(
                users[1].Id,
                "Wedding Anniversary",
                "Celebrating 25 years together with close family.",
                DateTime.UtcNow.AddDays(50),
                "Garden Venue",
                false,
                35).Value,
            Event.Create(
                users[2].Id,
                "Open Mic Night",
                "Showcase your talent at our weekly open mic.",
                DateTime.UtcNow.AddDays(3),
                "Jazz Club",
                true).Value,
            Event.Create(
                users[0].Id,
                "Strategy Planning Session",
                "Quarterly business strategy meeting.",
                DateTime.UtcNow.AddDays(11),
                "Conference Room A",
                false).Value,
            Event.Create(
                users[1].Id,
                "Science Fair",
                "Annual science fair for students and enthusiasts.",
                DateTime.UtcNow.AddDays(28),
                "Science Museum",
                true,
                200).Value,
            Event.Create(
                users[2].Id,
                "Birthday Surprise Party",
                "Secret birthday celebration.",
                DateTime.UtcNow.AddDays(13),
                "Friend's House",
                false,
                20).Value,
            Event.Create(
                users[0].Id,
                "Film Screening",
                "Independent film screening and Q&A.",
                DateTime.UtcNow.AddDays(21),
                "Indie Cinema",
                true).Value,
            Event.Create(
                users[1].Id,
                "Meditation Retreat",
                "Private weekend meditation and mindfulness retreat.",
                DateTime.UtcNow.AddDays(55),
                "Mountain Retreat Center",
                false).Value,
            Event.Create(
                users[2].Id,
                "Job Fair",
                "Connect with top employers in the region.",
                DateTime.UtcNow.AddDays(17),
                "Convention Center",
                true,
                500).Value,
            Event.Create(
                users[0].Id,
                "Alumni Gathering",
                "Private reunion for class of 2010.",
                DateTime.UtcNow.AddDays(70),
                "University Hall",
                false,
                50).Value,
        ];
    }

    internal static EventParticipant[] EventParticipants(Event[] events, User[] users)
    {
        return
        [
            new EventParticipant(events[0].Id, users[1].Id),
            new EventParticipant(events[0].Id, users[2].Id),
            new EventParticipant(events[0].Id, visitorId: VisitorIds[0], visitorFirstName: "Michael",
                visitorLastName: "Brown", visitorEmail: "michael.brown@example.com"),
            new EventParticipant(events[0].Id, visitorId: VisitorIds[1], visitorFirstName: "Sarah",
                visitorLastName: "Wilson", visitorEmail: "sarah.wilson@example.com"),
            new EventParticipant(events[1].Id, users[0].Id),
            new EventParticipant(events[1].Id, users[2].Id),
            new EventParticipant(events[1].Id, visitorId: VisitorIds[2], visitorFirstName: "David",
                visitorLastName: "Martinez", visitorEmail: "david.martinez@example.com"),
            new EventParticipant(events[1].Id, visitorId: VisitorIds[3], visitorFirstName: "Emma",
                visitorLastName: "Garcia", visitorEmail: "emma.garcia@example.com"),
            new EventParticipant(events[1].Id, visitorId: VisitorIds[4], visitorFirstName: "James",
                visitorLastName: "Anderson", visitorEmail: "james.anderson@example.com"),
            new EventParticipant(events[2].Id, users[0].Id),
            new EventParticipant(events[2].Id, visitorId: VisitorIds[1], visitorFirstName: "Sarah",
                visitorLastName: "Wilson", visitorEmail: "sarah.wilson@example.com"),
            new EventParticipant(events[3].Id, users[1].Id),
            new EventParticipant(events[3].Id, users[2].Id),
            new EventParticipant(events[4].Id, users[0].Id),
            new EventParticipant(events[4].Id, users[2].Id),
            new EventParticipant(events[4].Id, visitorId: VisitorIds[5], visitorFirstName: "Liam",
                visitorLastName: "Thomas", visitorEmail: "liam.thomas@example.com"),
            new EventParticipant(events[4].Id, visitorId: VisitorIds[6], visitorFirstName: "Sophia",
                visitorLastName: "Jackson", visitorEmail: "sophia.jackson@example.com"),
            new EventParticipant(events[4].Id, visitorId: VisitorIds[7], visitorFirstName: "Noah",
                visitorLastName: "White", visitorEmail: "noah.white@example.com"),
            new EventParticipant(events[5].Id, users[0].Id),
            new EventParticipant(events[5].Id, users[1].Id),
            new EventParticipant(events[5].Id, visitorId: VisitorIds[3], visitorFirstName: "Emma",
                visitorLastName: "Garcia", visitorEmail: "emma.garcia@example.com"),
            new EventParticipant(events[5].Id, visitorId: VisitorIds[8], visitorFirstName: "William",
                visitorLastName: "Martin", visitorEmail: "william.martin@example.com"),
            new EventParticipant(events[6].Id, users[1].Id),
            new EventParticipant(events[6].Id, users[2].Id),
            new EventParticipant(events[6].Id, visitorId: VisitorIds[9], visitorFirstName: "Isabella",
                visitorLastName: "Thompson", visitorEmail: "isabella.thompson@example.com"),
            new EventParticipant(events[7].Id, users[0].Id),
            new EventParticipant(events[7].Id, users[2].Id),
            new EventParticipant(events[7].Id, visitorId: VisitorIds[0], visitorFirstName: "Michael",
                visitorLastName: "Brown", visitorEmail: "michael.brown@example.com"),
            new EventParticipant(events[7].Id, visitorId: VisitorIds[10], visitorFirstName: "Charlotte",
                visitorLastName: "Lee", visitorEmail: "charlotte.lee@example.com"),
            new EventParticipant(events[7].Id, visitorId: VisitorIds[11], visitorFirstName: "Ethan",
                visitorLastName: "Walker", visitorEmail: "ethan.walker@example.com"),
            new EventParticipant(events[7].Id, visitorId: VisitorIds[12], visitorFirstName: "Amelia",
                visitorLastName: "Hall", visitorEmail: "amelia.hall@example.com"),
            new EventParticipant(events[8].Id, users[0].Id),
            new EventParticipant(events[8].Id, users[1].Id),
            new EventParticipant(events[9].Id, users[1].Id),
            new EventParticipant(events[9].Id, users[2].Id),
            new EventParticipant(events[9].Id, visitorId: VisitorIds[2], visitorFirstName: "David",
                visitorLastName: "Martinez", visitorEmail: "david.martinez@example.com"),
            new EventParticipant(events[9].Id, visitorId: VisitorIds[13], visitorFirstName: "Mia",
                visitorLastName: "Young", visitorEmail: "mia.young@example.com"),
            new EventParticipant(events[10].Id, users[0].Id),
            new EventParticipant(events[10].Id, users[2].Id),
            new EventParticipant(events[10].Id, visitorId: VisitorIds[14], visitorFirstName: "Lucas",
                visitorLastName: "King", visitorEmail: "lucas.king@example.com"),
            new EventParticipant(events[11].Id, users[0].Id),
            new EventParticipant(events[11].Id, users[1].Id),
            new EventParticipant(events[11].Id, visitorId: VisitorIds[1], visitorFirstName: "Sarah",
                visitorLastName: "Wilson", visitorEmail: "sarah.wilson@example.com"),
            new EventParticipant(events[11].Id, visitorId: VisitorIds[4], visitorFirstName: "James",
                visitorLastName: "Anderson", visitorEmail: "james.anderson@example.com"),
            new EventParticipant(events[11].Id, visitorId: VisitorIds[15], visitorFirstName: "Evelyn",
                visitorLastName: "Hill", visitorEmail: "evelyn.hill@example.com"),
            new EventParticipant(events[12].Id, users[1].Id),
            new EventParticipant(events[12].Id, users[2].Id),
            new EventParticipant(events[13].Id, users[0].Id),
            new EventParticipant(events[13].Id, users[2].Id),
            new EventParticipant(events[13].Id, visitorId: VisitorIds[16], visitorFirstName: "Henry",
                visitorLastName: "Scott", visitorEmail: "henry.scott@example.com"),
            new EventParticipant(events[13].Id, visitorId: VisitorIds[17], visitorFirstName: "Ella",
                visitorLastName: "Green", visitorEmail: "ella.green@example.com"),
            new EventParticipant(events[13].Id, visitorId: VisitorIds[3], visitorFirstName: "Emma",
                visitorLastName: "Garcia", visitorEmail: "emma.garcia@example.com"),
            new EventParticipant(events[14].Id, users[0].Id),
            new EventParticipant(events[14].Id, users[1].Id),
            new EventParticipant(events[15].Id, users[1].Id),
            new EventParticipant(events[15].Id, users[2].Id),
            new EventParticipant(events[15].Id, visitorId: VisitorIds[0], visitorFirstName: "Michael",
                visitorLastName: "Brown", visitorEmail: "michael.brown@example.com"),
            new EventParticipant(events[15].Id, visitorId: VisitorIds[18], visitorFirstName: "Daniel",
                visitorLastName: "Nelson", visitorEmail: "daniel.nelson@example.com"),
            new EventParticipant(events[16].Id, users[0].Id),
            new EventParticipant(events[16].Id, users[2].Id),
            new EventParticipant(events[17].Id, users[0].Id),
            new EventParticipant(events[17].Id, users[1].Id),
            new EventParticipant(events[17].Id, visitorId: VisitorIds[2], visitorFirstName: "David",
                visitorLastName: "Martinez", visitorEmail: "david.martinez@example.com"),
            new EventParticipant(events[17].Id, visitorId: VisitorIds[4], visitorFirstName: "James",
                visitorLastName: "Anderson", visitorEmail: "james.anderson@example.com"),
            new EventParticipant(events[17].Id, visitorId: VisitorIds[19], visitorFirstName: "Samuel",
                visitorLastName: "Perez", visitorEmail: "samuel.perez@example.com"),
            new EventParticipant(events[17].Id, visitorId: VisitorIds[20], visitorFirstName: "Lily",
                visitorLastName: "Roberts", visitorEmail: "lily.roberts@example.com"),
            new EventParticipant(events[18].Id, users[1].Id),
            new EventParticipant(events[18].Id, users[2].Id),
            new EventParticipant(events[18].Id, visitorId: VisitorIds[21], visitorFirstName: "Matthew",
                visitorLastName: "Turner", visitorEmail: "matthew.turner@example.com"),
            new EventParticipant(events[19].Id, users[0].Id),
            new EventParticipant(events[19].Id, users[2].Id),
            new EventParticipant(events[19].Id, visitorId: VisitorIds[10], visitorFirstName: "Charlotte",
                visitorLastName: "Lee", visitorEmail: "charlotte.lee@example.com"),
            new EventParticipant(events[19].Id, visitorId: VisitorIds[22], visitorFirstName: "Jackson",
                visitorLastName: "Campbell", visitorEmail: "jackson.campbell@example.com"),
            new EventParticipant(events[20].Id, users[0].Id),
            new EventParticipant(events[20].Id, users[1].Id),
            new EventParticipant(events[21].Id, users[1].Id),
            new EventParticipant(events[21].Id, users[2].Id),
            new EventParticipant(events[21].Id, visitorId: VisitorIds[17], visitorFirstName: "Ella",
                visitorLastName: "Green", visitorEmail: "ella.green@example.com"),
            new EventParticipant(events[21].Id, visitorId: VisitorIds[23], visitorFirstName: "Ryan",
                visitorLastName: "Evans", visitorEmail: "ryan.evans@example.com"),
            new EventParticipant(events[22].Id, users[0].Id),
            new EventParticipant(events[22].Id, users[2].Id),
            new EventParticipant(events[23].Id, users[0].Id),
            new EventParticipant(events[23].Id, users[1].Id),
            new EventParticipant(events[23].Id, visitorId: VisitorIds[1], visitorFirstName: "Sarah",
                visitorLastName: "Wilson", visitorEmail: "sarah.wilson@example.com"),
            new EventParticipant(events[24].Id, users[1].Id),
            new EventParticipant(events[24].Id, users[2].Id),
            new EventParticipant(events[25].Id, users[0].Id),
            new EventParticipant(events[25].Id, users[2].Id),
            new EventParticipant(events[25].Id, visitorId: VisitorIds[24], visitorFirstName: "Hannah",
                visitorLastName: "Collins", visitorEmail: "hannah.collins@example.com"),
            new EventParticipant(events[25].Id, visitorId: VisitorIds[25], visitorFirstName: "Isaac",
                visitorLastName: "Stewart", visitorEmail: "isaac.stewart@example.com"),
            new EventParticipant(events[25].Id, visitorId: VisitorIds[11], visitorFirstName: "Ethan",
                visitorLastName: "Walker", visitorEmail: "ethan.walker@example.com"),
            new EventParticipant(events[26].Id, users[0].Id),
            new EventParticipant(events[26].Id, users[1].Id),
            new EventParticipant(events[27].Id, users[1].Id),
            new EventParticipant(events[27].Id, users[2].Id),
            new EventParticipant(events[27].Id, visitorId: VisitorIds[15], visitorFirstName: "Evelyn",
                visitorLastName: "Hill", visitorEmail: "evelyn.hill@example.com"),
            new EventParticipant(events[28].Id, users[0].Id),
            new EventParticipant(events[28].Id, users[2].Id),
            new EventParticipant(events[29].Id, users[0].Id),
            new EventParticipant(events[29].Id, users[1].Id),
            new EventParticipant(
                events[29].Id,
                visitorId: VisitorIds[2],
                visitorFirstName: "David",
                visitorLastName: "Martinez",
                visitorEmail: "david.martinez@example.com"),
            new EventParticipant(
                events[29].Id,
                visitorId: VisitorIds[26],
                visitorFirstName: "Caleb",
                visitorLastName: "Reed",
                visitorEmail: "caleb.reed@example.com"),
            new EventParticipant(
                events[29].Id,
                visitorId: VisitorIds[27],
                visitorFirstName: "Scarlett",
                visitorLastName: "Cook",
                visitorEmail: "scarlett.cook@example.com"),
            new EventParticipant(events[30].Id, users[1].Id),
            new EventParticipant(events[30].Id, users[2].Id),
            new EventParticipant(
                events[30].Id,
                visitorId: VisitorIds[0],
                visitorFirstName: "Michael",
                visitorLastName: "Brown",
                visitorEmail: "michael.brown@example.com"),
        ];
    }

    internal static EventTag[] EventTags(Event[] events, Tag[] tags)
    {
        return
        [
            // Community Meetup - Networking, Business, Education
            new EventTag(events[0].Id, tags[4].Id), // Networking (existing)
            new EventTag(events[0].Id, tags[8].Id), // Business
            new EventTag(events[0].Id, tags[3].Id), // Education

            // Tech Conference - Technology, Business, Networking, Education
            new EventTag(events[1].Id, tags[0].Id), // Technology (existing)
            new EventTag(events[1].Id, tags[8].Id), // Business
            new EventTag(events[1].Id, tags[4].Id), // Networking
            new EventTag(events[1].Id, tags[3].Id), // Education

            // Art Workshop - Art, Education, Networking
            new EventTag(events[2].Id, tags[1].Id), // Art (existing)
            new EventTag(events[2].Id, tags[3].Id), // Education
            new EventTag(events[2].Id, tags[4].Id), // Networking

            // Private Dinner Party - Business, Food & Drink, Networking
            new EventTag(events[3].Id, tags[8].Id), // Business (existing)
            new EventTag(events[3].Id, tags[7].Id), // Food & Drink
            new EventTag(events[3].Id, tags[4].Id), // Networking

            // Board Game Night - Education, Networking
            new EventTag(events[4].Id, tags[3].Id), // Education (existing)
            new EventTag(events[4].Id, tags[4].Id), // Networking

            // Yoga Class - Music, Health, Education
            new EventTag(events[5].Id, tags[5].Id), // Music (existing)
            new EventTag(events[5].Id, tags[2].Id), // Health
            new EventTag(events[5].Id, tags[3].Id), // Education

            // Family Reunion - Travel, Food & Drink, Networking
            new EventTag(events[6].Id, tags[9].Id), // Travel (existing)
            new EventTag(events[6].Id, tags[7].Id), // Food & Drink
            new EventTag(events[6].Id, tags[4].Id), // Networking

            // City Marathon - Sports, Health, Business, Travel
            new EventTag(events[7].Id, tags[6].Id), // Sports (existing)
            new EventTag(events[7].Id, tags[2].Id), // Health
            new EventTag(events[7].Id, tags[8].Id), // Business
            new EventTag(events[7].Id, tags[9].Id), // Travel

            // Book Club Meeting - Health, Education, Networking
            new EventTag(events[8].Id, tags[2].Id), // Health (existing)
            new EventTag(events[8].Id, tags[3].Id), // Education
            new EventTag(events[8].Id, tags[4].Id), // Networking

            // Cooking Workshop - Technology, Food & Drink, Education, Business
            new EventTag(events[9].Id, tags[0].Id), // Technology (existing)
            new EventTag(events[9].Id, tags[7].Id), // Food & Drink
            new EventTag(events[9].Id, tags[3].Id), // Education
            new EventTag(events[9].Id, tags[8].Id), // Business

            // Investment Seminar - Business, Education, Networking, Technology
            new EventTag(events[10].Id, tags[8].Id), // Business (existing)
            new EventTag(events[10].Id, tags[3].Id), // Education
            new EventTag(events[10].Id, tags[4].Id), // Networking
            new EventTag(events[10].Id, tags[0].Id), // Technology

            // Music Festival - Music, Art, Travel, Food & Drink, Business
            new EventTag(events[11].Id, tags[5].Id), // Music (existing)
            new EventTag(events[11].Id, tags[1].Id), // Art
            new EventTag(events[11].Id, tags[9].Id), // Travel
            new EventTag(events[11].Id, tags[7].Id), // Food & Drink
            new EventTag(events[11].Id, tags[8].Id), // Business

            // Wine Tasting Evening - Food & Drink, Business, Networking
            new EventTag(events[12].Id, tags[7].Id), // Food & Drink (existing)
            new EventTag(events[12].Id, tags[8].Id), // Business
            new EventTag(events[12].Id, tags[4].Id), // Networking

            // Photography Masterclass - Art, Education, Technology, Business
            new EventTag(events[13].Id, tags[1].Id), // Art (existing)
            new EventTag(events[13].Id, tags[3].Id), // Education
            new EventTag(events[13].Id, tags[0].Id), // Technology
            new EventTag(events[13].Id, tags[8].Id), // Business

            // Corporate Team Building - Networking, Business, Sports, Health
            new EventTag(events[14].Id, tags[4].Id), // Networking (existing)
            new EventTag(events[14].Id, tags[8].Id), // Business
            new EventTag(events[14].Id, tags[6].Id), // Sports
            new EventTag(events[14].Id, tags[2].Id), // Health

            // Street Food Festival - Education, Food & Drink, Travel, Business
            new EventTag(events[15].Id, tags[3].Id), // Education (existing)
            new EventTag(events[15].Id, tags[7].Id), // Food & Drink
            new EventTag(events[15].Id, tags[9].Id), // Travel
            new EventTag(events[15].Id, tags[8].Id), // Business

            // Poetry Reading Circle - Travel, Art, Education
            new EventTag(events[16].Id, tags[9].Id), // Travel (existing)
            new EventTag(events[16].Id, tags[1].Id), // Art
            new EventTag(events[16].Id, tags[3].Id), // Education

            // Blockchain Summit - Health, Technology, Business, Education, Networking
            new EventTag(events[17].Id, tags[2].Id), // Health (existing)
            new EventTag(events[17].Id, tags[0].Id), // Technology
            new EventTag(events[17].Id, tags[8].Id), // Business
            new EventTag(events[17].Id, tags[3].Id), // Education
            new EventTag(events[17].Id, tags[4].Id), // Networking

            // Bachelor Party - Technology, Travel, Food & Drink, Sports
            new EventTag(events[18].Id, tags[0].Id), // Technology (existing)
            new EventTag(events[18].Id, tags[9].Id), // Travel
            new EventTag(events[18].Id, tags[7].Id), // Food & Drink
            new EventTag(events[18].Id, tags[6].Id), // Sports

            // Charity Walk - Sports, Health, Business, Networking
            new EventTag(events[19].Id, tags[6].Id), // Sports (existing)
            new EventTag(events[19].Id, tags[2].Id), // Health
            new EventTag(events[19].Id, tags[8].Id), // Business
            new EventTag(events[19].Id, tags[4].Id), // Networking

            // Exclusive Product Launch - Business, Technology, Networking, Art
            new EventTag(events[20].Id, tags[8].Id), // Business (existing)
            new EventTag(events[20].Id, tags[0].Id), // Technology
            new EventTag(events[20].Id, tags[4].Id), // Networking
            new EventTag(events[20].Id, tags[1].Id), // Art

            // Dance Class Beginner - Music, Health, Education, Art
            new EventTag(events[21].Id, tags[5].Id), // Music (existing)
            new EventTag(events[21].Id, tags[2].Id), // Health
            new EventTag(events[21].Id, tags[3].Id), // Education
            new EventTag(events[21].Id, tags[1].Id), // Art

            // Wedding Anniversary - Food & Drink, Travel, Music
            new EventTag(events[22].Id, tags[7].Id), // Food & Drink (existing)
            new EventTag(events[22].Id, tags[9].Id), // Travel
            new EventTag(events[22].Id, tags[5].Id), // Music

            // Open Mic Night - Art, Music, Education, Networking
            new EventTag(events[23].Id, tags[1].Id), // Art (existing)
            new EventTag(events[23].Id, tags[5].Id), // Music
            new EventTag(events[23].Id, tags[3].Id), // Education
            new EventTag(events[23].Id, tags[4].Id), // Networking

            // Strategy Planning Session - Networking, Business, Education
            new EventTag(events[24].Id, tags[4].Id), // Networking (existing)
            new EventTag(events[24].Id, tags[8].Id), // Business
            new EventTag(events[24].Id, tags[3].Id), // Education

            // Science Fair - Education, Technology, Art, Networking
            new EventTag(events[25].Id, tags[3].Id), // Education (existing)
            new EventTag(events[25].Id, tags[0].Id), // Technology
            new EventTag(events[25].Id, tags[1].Id), // Art
            new EventTag(events[25].Id, tags[4].Id), // Networking

            // Birthday Surprise Party - Travel, Food & Drink, Music
            new EventTag(events[26].Id, tags[9].Id), // Travel (existing)
            new EventTag(events[26].Id, tags[7].Id), // Food & Drink
            new EventTag(events[26].Id, tags[5].Id), // Music

            // Film Screening - Health, Art, Education, Business
            new EventTag(events[27].Id, tags[2].Id), // Health (existing)
            new EventTag(events[27].Id, tags[1].Id), // Art
            new EventTag(events[27].Id, tags[3].Id), // Education
            new EventTag(events[27].Id, tags[8].Id), // Business

            // Meditation Retreat - Sports, Health, Education, Travel
            new EventTag(events[28].Id, tags[6].Id), // Sports (existing)
            new EventTag(events[28].Id, tags[2].Id), // Health
            new EventTag(events[28].Id, tags[3].Id), // Education
            new EventTag(events[28].Id, tags[9].Id), // Travel

            // Job Fair - Technology, Business, Education, Networking
            new EventTag(events[29].Id, tags[0].Id), // Technology (existing)
            new EventTag(events[29].Id, tags[8].Id), // Business
            new EventTag(events[29].Id, tags[3].Id), // Education
            new EventTag(events[29].Id, tags[4].Id), // Networking

            // Alumni Gathering - Business, Education, Networking, Travel
            new EventTag(events[30].Id, tags[8].Id), // Business (existing)
            new EventTag(events[30].Id, tags[3].Id), // Education
            new EventTag(events[30].Id, tags[4].Id), // Networking
            new EventTag(events[30].Id, tags[9].Id), // Travel
        ];
    }
}