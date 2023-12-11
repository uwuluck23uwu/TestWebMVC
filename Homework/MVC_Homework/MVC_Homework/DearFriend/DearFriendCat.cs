﻿namespace MVC_Homework.DearFriend
{
    public class DearFriendCat
    {
        public static List<string> Name { get; set; } = new List<string>()
        {
            "Sphinx","Maine Coon","Persian","British Shorthair"
        };

        public static List<string> Img { get; set; } = new List<string>()
        {
            "https://www.purina.co.th/sites/default/files/styles/ttt_image_original/public/2021-02/CAT%20BREED%20Hero%20Desktop_0003_Sphynx.webp?itok=AJfdmSmY",
            "https://www.purina.co.th/sites/default/files/styles/ttt_image_original/public/2021-02/CAT%20BREED%20Hero%20Desktop_0022_Maine_coon.webp?itok=LhD0vLe7",
            "https://www.purina.co.th/sites/default/files/styles/ttt_image_original/public/2021-02/CAT%20BREED%20Hero%20Desktop_0015_Persian.webp?itok=e3BqIEsK",
            "https://www.purina.co.th/sites/default/files/styles/ttt_image_original/public/2021-02/CAT%20BREED%20Hero%20Desktop_0036_British_shorthair.webp?itok=UToBSCFZ"
        };

        public static List<string> Description { get; set; } = new List<string>()
        {
            "จุดเด่นของแมวสฟิงซ์คือเป็นแมว “ไร้ขน” แม้ดูภายนอกจะเหมือนแมวไร้ขน แต่อันที่จริงแล้วสฟิงซ์มีขนนุ่มละเอียดปกคลุมทั่วรางกาย ให้สัมผัสเหมือนเปลือกลูกพีช แมวพันธุ์นี้ไม่มีหนวดและขนตา หัวมีรูปทรงคล้ายกับหัวของแมวเดวอน เร็กซ์ ดวงตาลึกกลมคล้ายเลมอน รูปร่างของสฟิงซ์บอบบางแต่มีกล้ามเนื้อ อกหนากลม ขาเรียวยาวและดูโก่งจากอกทรงกลม หางยาวเรียวและสากเมื่อสัมผัส",
            "แมวเมนคูนเป็นสายพันธุ์แมวขนาดใหญ่ที่สุดในโลก รูปร่างแข็งแรงกำยาและขาแข็งแรง หัวทรงเหลี่ยม ใบหูใหญ่และตั้งตรง ขนด้านนอกมีลักษณะยาวหนาเป็นมันและกันน้ำได้ดี มีขนชั้นในซ่อนอยู่ข้างใต้ ส่วนขนที่หัว คอและไหล่จะสั้นกว่าจุดอื่นแต่จะค่อย ๆ ยาวขึ้นเรื่อย ๆ บริเวณส่วนหลัง ข้างลำตัวและหาง ส่วนท้องกับสะโพกมีขนดกและหนา ที่โคนหูจะมีขนยาวเป็นพู่งามสง่า",
            "แมวเปอร์เซีย หรือ Persian Cat คือหนึ่งในสายพันธุ์น้องแมวขนสวยยาวเงางาม และจัดเป็นหนึ่งในสิบสายพันธุ์แมว ที่ได้รับความนิยมนำมาเลี้ยงมากที่สุดบนโลกสายพันธุ์หนึ่ง ด้วยขนที่สวย บวกกับความน่ารัก ความจงรักภักดีต่อเจ้าของ รักความสงบ ไม่ส่งเสียงดังเอะอะ และความฉลาดแสนรู้ของแมวเปอร์เซีย ทำให้น้องแมวสายพันธุ์นี้มัดใจให้หลายคนตกหลุมรักกันแบบถอนตัวไม่ขึ้น",
            "ทำความรู้จักบริติช ช็อตแฮร์ (British Shorthair) ว่ากันว่า British shorthair เป็นหนึ่งในสายพันธุ์แมวที่เก่าแก่ที่สุดของประเทศอังกฤษ ด้วยลักษณะเด่นที่มีขนหนานุ่มน่ากอด กับนิสัยเท่ๆ ถึงจะอยู่แบบเงียบๆ แต่ก็เข้ากับทุกคนได้ง่าย แถมยังเป็นมิตรอีกต่างหากถ้าใครกำลังมองหาเพื่อนแท้ซักตัวที่จะอยู่เคียงข้างแบบไม่กวนใจ มองมาทางนี้เลย",
        };

        public static List<string> Overview { get; set; } = new List<string>()
        {
            "น้ำหนัก : สฟิงซ์ที่มีสุขภาพดีจะมีน้ำหนักประมาณ 3.6-7.2 กก. \n" +
            "ส่วนสูง : ส่วนสูงโดยเฉลี่ยของสฟิงซ์ในช่วงโตเต็มวัยจะอยู่ที่ประมาณ 20-25 ซม. \n" +
            "อายุขัย : สฟิงซ์มีอายุขัยเฉลี่ยประมาณ 13-14 ปี \n" +
            "ลักษณะขน : สฟิงซ์อาจไม่มีขนเลย หรืออาจมีขนเหมือนพีชที่สั้นและละเอียดมาก",

            "น้ำหนัก : แมวสายพันธุ์เมนคูนมักจะมีน้ำหนักประมาณ 5 – 8 กก. \n" +
            "ส่วนสูง : ส่วนสูงโดยเฉลี่ยของเมนคูนในช่วงโตเต็มวัยจะอยู่ที่ประมาณ 16-18 \n" +
            "อายุขัย : เมนคูนมีอายุขัยเฉลี่ยประมาณ 15-17 ปีขึ้นไป \n" +
            "ลักษณะขน : เจ้าเหมียวพันธุ์เมนคูนมีขนหนาและยาวคล้ายเส้นไหม",

            "น้ำหนัก : เปอร์เซียที่มีสุขภาพดีจะมีน้ำหนักประมาณ 3 – 5 กก.\n" +
            "ความสูง : ส่วนสูงโดยเฉลี่ยของเปอร์เซียในช่วงโตเต็มวัยจะอยู่ที่ประมาณ 10 – 15 นิ้ว \n" +
            "อายุขัย : สฟิงซ์มีอายุขัยเฉลี่ยประมาณ 12 – 17 ปี \n" +
            "ลักษณะขน : ขนยาวสลวย หนาสองชั้น",

            "น้ำหนัก : บริติช ช็อตแฮร์ที่มีสุขภาพดีจะมีน้ำหนักประมาณ 4 – 7 กก. \n" +
            "ส่วนสูง : ส่วนสูงโดยเฉลี่ยของบริติช ช็อตแฮร์ในช่วงโตเต็มวัยจะอยู่ที่ประมาณ 12 – 14 นิ้ว \n" +
            "อายุขัย : บริติช ช็อตแฮร์มีอายุขัยเฉลี่ยประมาณ 12 – 15 ปี \n" +
            "ลักษณะขน : แม้จะมีขนสั้น แต่ขนของบริติช ช็อตแฮร์ก็หนาและแน่นมาก",
        };

        public static List<string> Character { get; set; } = new List<string>()
        {
            "แมวสฟิงซ์เข้าสังคมเก่ง ซุกซน เป็นมิตร และชอบให้คนสนใจ แมวไร้ขนพันธุ์นี้มักคอยต้อนรับเจ้าของเมื่อกลับถึงบ้าน และยังคุยเก่งอีกด้วย เป็นแมวที่ฉลาด ขี้เล่น และน่ากอด สฟิงซ์เป็นสุดยอดแมว “ขี้อ้อน” ชอบนอนใต้ผ้าห่มกับเจ้าของ อุณหภูมิร่างกายของสฟิงซ์สูงกว่าแมวทั่วไปโดยเฉลี่ย 1-2 องศา",
            "แมวเมนคูนมีนิสัยอ่อนโยน ขี้เล่นและเป็นมิตร ชอบอยู่ใกล้คนและเป็นสัตว์เลี้ยงที่ดี อาจเป็นเพราะลักษณะที่ไม่เย่อหยิ่งทำให้พบแมวเมนคูนนอนขดอยู่ในที่แปลก ๆ ได้",
            "แมวเปอร์เซียจะค่อนข้างเงียบและไม่ซุกซน ชอบที่จะนั่งนิ่งๆ อยู่ข้างกายเจ้าของแบบสงบเสงี่ยม มีความเป็นมิตรกับสมาชิกในครอบครัวรวมทั้งเด็ก แต่จะไม่ชอบถ้าเด็กหรือสัตว์เลี้ยงตัวอื่นมากวน หรือมายุ่งวุ่นวาย และมักเป็นแมวที่ได้รับความสนใจจากสมาชิกในครอบครัว แต่มีเพียงไม่กี่คนหรอกนะที่น้องแมวเปอร์เซียจะรู้สึกไว้ใจ",
            "น้องแมวบริติช ช็อตแฮร์ นั้นน่ารัก เรียบร้อย และเข้ากับคนอื่นง่าย ทำให้น้องกลายเป็นแมวเลี้ยงที่ลงตัวมากสำหรับครอบครัว น้องแมวบริติช ช็อตแฮร์ ชอบที่จะเป็นรักและสนใจจากคนรอบข้าง แต่ก็ไม่ได้เรียกร้องความสนใจจนมากเกินไป น้องมักชอบเดินตามเจ้าของไปรอบๆ บ้านแล้วนั่งลงข้างๆ ไม่ว่าคุณจะทำอะไร",
        };
    }
}
