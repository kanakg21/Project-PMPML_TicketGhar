<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index .aspx.cs" Inherits="PMPML_TIcketGhar.User.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link
      href="https://cdn.jsdelivr.net/npm/remixicon@3.4.0/fonts/remixicon.css"
      rel="stylesheet"
    />
    <link rel="stylesheet" href="../UserTemplate/css/styles.css" />
    <title>TicketKara</title>
</head>
<body>
    <form id="form1" runat="server">
       <nav>
      
      <div class="nav__logo"><img src="../UserTemplate/image/PMPMPLOGO.png" style="width: 70px;"></div>
      <ul class="nav__links">
        <li class="link"><a href="index.aspx">Home </a></li>
        <li class="link"><a href="About.aspx">About US</a></li>
        <li class="link"><a href="Addhar_registration.aspx">Registation</a></li>
        <li class="link"><a href="#"></a></li>
        <li class="link"><a href="#"></a></li>
      </ul>
      <%--<button class="btn">Contact</button>--%>
      <%--<asp:Button ID="btnContact" runat="server" CssClass="btn" Text="Contact" OnClick="btnContact_Click" />--%>
           <asp:LinkButton ID="btnExample" runat="server" CssClass="btn-link" OnClick="btnExample_Click" BorderColor="#666666" ForeColor="#666666">
    Contact
</asp:LinkButton>
    </nav>
    
    <header class="section__container header__container">
      
      <h1 class="section__header" style="text-align: center;">Pune (PMPML) Online TicketGhar<br />
        पुणे (PMPML) Online तिकीट घर</h1>
      <img src="../UserTemplate/image/bus-lined-up-at-depot.jpg" />
     </header>

    <section class="section__container booking__container">
      <div class="booking__nav">
        <span>Ticket <br>तिकीट
        </span>
        <span><a href="Daily_Pass.aspx">Daily Pass <br>दैनिक पास</a></span>
       <span> <a href="respo_document_req.aspx">Monthly Pass <br> मासिक पास</a></span>
        
      </div>
        <%-- ticket book form --%>
      <form>
        <div class="form__group">
          <span><i class="ri-map-pin-line"></i></span>
          <div class="input__content">
            <div class="input__group">
              <input type="text" id="inputField1" name="inputField1" pattern="[A-Za-z ]*" title="Only alphabets and spaces are allowed" required>
              <label>From:</label>
            </div>
            <p>पासून (प्रवास सुरू होण्याचे ठिकाण)</p>
          </div>
        </div>
        <div class="form__group">
          <span><i class="ri-map-pin-line"></i></span>
          <div class="input__content">
            <div class="input__group">
              <input type="text" id="inputField2" name="inputField2" pattern="[A-Za-z ]*" title="Only alphabets and spaces are allowed" required>
              <label>To:</label>
            </div>
            <p>पर्यंत(पोहोचण्याचे ठिकाण)</p>
          </div>
        </div>
        <div class="form__group">
          <span><i class="ri-user-3-line"></i></span>
          <div class="input__content">
            <div class="input__group">
              <input type="Number" id="travelers" name="travelers" pattern="\d{5}" required/>
              <label>Travelers</label>
            </div>
            <p>प्रवासी संख्या</p>
          </div>
        </div>
        <div class="form__group">
          <span><i class="ri-calendar-line"></i></span>
          <div class="input__content">
            <div class="input__group">
              <input type="text" id="numericInput" name="numericInput" pattern="\d{12}" title="Please enter exactly 12 digits" required>
              <label>Aadhar Number</label>
            </div>
            <p>आधार क्रमांक</p>
          </div>
        </div>
        <%--<button class="btn"><i class="ri-search-line"> </i></button>
          <asp:LinkButton ID="btnSearch" runat="server" CssClass="btn" OnClick="btnSearch_Click">
    <i class="ri-search-line"></i>
</asp:LinkButton>--%>
          <asp:Button ID="btnSearch" runat="server" CssClass="search-button" Text="Search" OnClick="btnSearch_Click" BackColor="#00CC00" />

          


         
      </form>
    </section>

    <section class="section__container plan__container">
      <p class="subheader">Travel Suporters</p>
      <h2 class="section__header">पुणे महानगरपालिका सेवेसाठी तत्परतेने कार्यरत आहे</h2>
      <p class="description">
        Book your ticket online and enjoy your traveling.
      </p>
      <div class="plan__grid">
        <div class="plan__content">
          <img src="../UserTemplate/image/PMPML_logo.png" style="width: 300px; margin-left:75%; margin-top: auto; border-radius: 20px; box-shadow: 5px 5px 30px rgba(1, 1, 1, 1); " />
          <span class="number">01</span>
          <h4>(PMPML)</h4>
          <p>
            PMPML is the city's efficient public transport system, operating as a modern institution facilitating travel across various junctions. Pune has become a modern and excellent central hub for education, employment, and entrepreneurship. Every day, a significant number of citizens from all parts of the country come here for jobs, education, and tourism. PMPML plays a crucial role in providing efficient public transportation services to these incoming citizens and travelers. While delivering these services, PMPML makes optimal use of all technological systems to offer safe and sustainable services at minimal bus fares. PMPML's significant participation contributes substantially to Pune city's rapid development. PMPML efficiently provides transport services within the twenty-kilometer radius of Pune city, the industrially renowned Pimpri Chinchwad city, and the adjoining urban and rural areas.
          
          </p>
          <span class="number">0१</span>
          <h4>पुणे महानगर पालिका परिवहन मंडळ</h4>
          <p>
            पीएमपीएमएल या शहरातील सक्षम सार्वजनीक वाहतूक व्यवस्था असून चौका-चौकातून आधुनिकतेच्या व्दारातून प्रवास करणारी संस्था आहे. पुणे शहर हे शहर शिक्षण, नोकरी, उद्योजक या सर्वांचे आधुनिक उत्कृष्ठ मध्यवर्ती केंद्र बनले आहे. येथे दररोज देशातील सर्व भागातून मोठया प्रमाणात रोजगारासाठी, शिक्षणासाठी, पर्यटनासाठी नागरीक येत असतात. या येणाऱ्या नागरिकांना/प्रवाशांना सक्षम सार्वजनिक वाहतूक सेवा पुरविण्याची महत्वाची भुमिका बजावत आहे. ही सेवा बजावताना तंत्रज्ञानातील सर्व प्रणालींचा सर्वोत्तम वापर करून प्रवाशांना कमीत कमी बस भाडे आकारून सुरक्षीत व शास्वत सेवा पीएमपीएमएल पुरवित आहे. पुणे शहराच्या जलद गतीने होणाऱ्या विकासामध्ये पीएमपीएमएल चा सहभाग मोठ्या प्रमाणात आहे. पुणे शहर, पुणे शहरा लगतचे औद्योगिक नगरी म्हणून नावाजलेले पिंपरी चिंचवड शहर या दोन्ही शहरालगत असणाऱ्या वीस किलोमीटर हद्दीपर्यंतच्या नागरी व ग्रामीण भागामध्ये पीएमपीएमएल वाहतुक सेवा कार्यक्षमपणे पुरवीत आहे.
          </p>
          
         
        
          <span class="number">0२</span>
          <h4>पुणे महानगर पालिका </h4>
          <p>
            पुणे महानगरपालिका, 1950 पासून नागरिकांची सेवा करत आहे. नागरिकांना उत्तम सेवा देण्यासाठी पुणे महानगरपालिकेने ई-शासनासाठी पुढाकार घेतला आहे. पुणे, पूर्वेचे ऑक्सफर्ड, हे भारतातील ऐतिहासिक शहर आहे ज्याचा वैभवशाली इतिहास, नाविन्यपूर्ण वर्तमान आणि आशादायक भविष्य आहे. 
          </p>
        </div>
        <div class="plan__image">
          <img src="../UserTemplate/image/chhatrapati-shivaji-maharaj-statue-katraj-pune-rajesh-avhad.jpg" alt="plan" />
          <img src="../UserTemplate/image/images.jpeg" alt="plan" />
          <img src="../UserTemplate/image/pmc.jpg" alt="plan" />
        </div>
        
    </section>

    <section class="memories">
      <div class="section__container memories__container">
        <div class="memories__header">
          <h2 class="section__header">
           Why to  Use (PMPL) Online TicketGhar.
          </h2>
          <%--<button class="view__all">View All</button>--%>
           <%--<asp:Button ID="btnViewAll" runat="server" CssClass="view__all" Text="View All" OnClick="btnViewAll_Click" />--%>

        </div>
        <div class="memories__grid">
          <div class="memories__card">
            <span><i class="ri-shield-check-line"></i></span>
            <h4>Book ticket in three steps</h4>
            <p>
              Book your ticket from (PMPL)Online TicketGhar.in three easy steps and enjoy your journey.
            </p>
          </div>
          <div class="memories__card">
            <span><i class="ri-calendar-2-line"></i></span>
            <h4>Online month Pass</h4>
            <p>
              Get a Student pass or other mounthly pass easly.Document verification is also online so no need to visit the (PMPL) offices.
            </p>
          </div>
          <div class="memories__card">
            <span><i class="ri-bookmark-2-line"></i></span>
            <h4>Save time And Efforts</h4>
            <p>
             Everthing related to tickets , daily Passes ,monthly passes and document verification related to passes is here now then save your time and efforts just use(PMPL)TicketGhar.
            </p>
          </div>
        </div>
      </div>
    </section>

    <section class="section__container lounge__container">
      <div class="lounge__image">
        <img src="../UserTemplate/image/pune darshan bus 2.jpg" alt="lounge" />
        <img src="../UserTemplate/image/OLECTRA_Electric_Bus.jpeg" alt="lounge" />
      </div>
      
      <div class="lounge__content">
        <h2 class="section__header">Best E Buses</h2>
        <div class="lounge__grid">
          <div class="lounge__details">
            <h4> AC OLECTRA_Electric_Bus</h4>
            <p> 
              Clean E-buses offer eco-friendly transportation solutions with reduced emissions, contributing to a cleaner environment and a sustainable future for urban mobility.
            </p>
            
          </div>
          <div class="lounge__details">
            <h4>Special Buses for Pune tour <br>(पुणे दर्शन) </h4>
            <p>
              For Pune Tour(पुणे दर्शन), these buses will provide you comfort and safety.
            </p>
          </div>
          <div class="lounge__details">
            <h4>Special buses for Womens </h4>
            <p>
             (PMPML) provides spicial buses for Womens .
            </p>
           
          </div>
          <div class="lounge__details">
            <h4>Experienced Staff</h4>
            <p>
              Well-trained and experienced drivers and ticket conductors are present on the buses.
            </p>
          </div>
        </div>
      </div>
    </section>

    <section class="section__container travellers__container">
      <h2 class="section__header"></h2>
      <div class="travellers__grid">
        <div class="travellers__card">
          <img src="../UserTemplate/image/Shaniwaarwada_Pune_11zon.jpg" alt="traveller" />
          <div class="travellers__card__content">
            <img src="../UserTemplate/image/shivaji-maharaj-and-shaniwar-wada-fort-maharashtra-vector-50470698.jpg" alt="client" />
            <h4>ShaniwarWada</h4>
            <p>The Shaniwar Wada was normally the seven-story capital building of the Peshwas of the Maratha Empire. It was supposed to be made entirely of stone. However, after the completion of the base floor or the first story, the people of Satara (the national capital) complained to the Chhatrapati Shahu I (Emperor) saying that a stone monument can be sanctioned and built only by the emperor himself and not the Peshwas. Following this, an official letter was written to the Peshwas stating that the remaining building had to be made of brick and not stone.</p>
          </div>
        </div>
        <div class="travellers__card">
          <img src="../UserTemplate/image/1651224930143200465.jpg" alt="traveller" />
          <div class="travellers__card__content">
            <img src="../UserTemplate/image/Shri Ganesh download.jpeg" alt="client" />
            <h4>DagaluSheth Halwai Ganpati</h4>
            <p>The Dagadusheth Halwai Ganapati temple is a Hindu Temple located in Pune and is dedicated to the Hindu god Ganesh. The temple is visited by over hundred thousand pilgrims every year. Devotees of the temple include celebrities and chief ministers of Maharashtra who visit during the annual ten-day Ganeshotsav festival.</p>
          </div>
        </div>
        <div class="travellers__card">
          <img src="../UserTemplate/image/lalfeb-22 (1).jpg" alt="traveller" />
          <div class="travellers__card__content">
            <img src="../UserTemplate/image/AA_LM_03.jpg" alt="client" />
            <h4>Lal Mahal</h4>
            <p>In the year 1630 AD, Shivaji's Father Shahaji, established the Lal Mahal for his wife Jijabai and son.Chhatrapati Shivaji Maharaj stayed here for many years till he captured the first fort. The current Lal Mahal is a reconstruction of the original and located in the center of the Pune city. The original Lal Mahal was built with the idea of rejuvenating the recently razed city of Pune when Shahaji Raje entered the city along with Shivaji and his mother, Maasaheb Jijabai. Young Shivaji grew up here, and stayed in the Lal Mahal till he captured the Torna fort in 1645. Shivaji's marriage with his first wife, Saibai took place in Lal Mahal on 16 May 1640.</p>
          </div>
        </div>
        <div class="travellers__card">
          <img src="../UserTemplate/image/1676533384212-Pratapgarh Mobile.jpg" alt="traveller" />
          <div class="travellers__card__content">
            <img src="../UserTemplate/image/Tanhaji download.jpeg" alt="client" />
            <h4>Sinhgad Fort</h4>
            <p>Sinhagad, ealier known as ‘Kondhana’ is the most prominent and popular fort in Pune.It is located at village Donaje, taluka-Haveli. It is 25 km away from Pune on a hill 1290 m high. Tanaji Malusare-Chh. Shivaji’s trsusted and brave general,fought a battle here all alone with the Mughal army. on hearing news of his death, Chh.Shivaji said. “We won the fort but lost the lion” (“Gad Ala Pan Sinha Gela”), and so after his death Chh. Shivaji renamed this “Kondhana” fort as “Sinhagad”.</p>
          </div>
        </div>
      </div>
    </section>

    <section class="subscribe">
      <div class="section__container subscribe__container">
       
        <form class="subscribe__form">
          <input type="text" placeholder="Enter your Email and Feedback" />
          <button class="btn">Feedback</button>
            <%--<asp:Button ID="btnFeedback" runat="server" CssClass="btn" Text="Feedback" OnClick="btnFeedback_Click" />--%>

        </form>
      </div>
    </section>

    <footer class="footer">
      <div class="section__container footer__container">
        <div class="footer__col">
          <h3>(PMPL)TicketGhar</h3>
          <p>
            Booking a bus ticket online on the (PMPML)TicketGhar app or website is very simple. You can download the (PMPML)TicketGhar app or visit (PMPML)TicketGhar.in and enter your source, destination & travel in (PMPML)TicketGhar it will help you in ticket booking. You can pay using multiple payment options like UPI, debit or credit card, net banking and more. With (PMPL)TicketGhar, get assured safe & secure payment methods. Once the bus ticket booking payment is confirmed,You can enjoy travel with the us. Online bus ticket booking with (PMPL)TicketGhar is that simple!

          </p>
          <p>
            (PMPML)Buses provides you safe, comfortable, and unforgettable experiences.
          </p>
        </div>
        <div class="footer__col">
          <h4>INFORMATION</h4>
          <p>Home</p>
          <p>About</p>
          
          
        </div>
        <div class="footer__col">
          <h4>CONTACT</h4>
          <p>Support</p>
          <p>Media</p>
          <p>Socials</p>
        </div>
      </div>
      <div class="section__container footer__bar">
        <p>Copyright © 2024 IETDAC Group21. All rights reserved.</p>
        <div class="socials">
          <span><i class="ri-facebook-fill"></i></span>
          <span><i class="ri-twitter-fill"></i></span>
          <span><i class="ri-instagram-line"></i></span>
          <span><i class="ri-youtube-fill"></i></span>
        </div>
      </div>
    </footer>
    </form>
</body>
</html>
