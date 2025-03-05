# Q1_FindMostCommonWord
การทำงานของฟังก์ชัน FindMostCommonWord หลังรับค่า Text (string):
1. wordsDic (Dictionary<string, int>): ใช้เก็บจำนวนของคำที่พบในข้อความ โดยใช้คำเป็น Key และจำนวนคำ Value
2. words: แบ่งข้อความเป็นคำโดยใช้ Delimiter ด้วย ( .,!?;") และเก็บในอาเรย์
3. loop : อ่านคำจาก words:
ถ้าคำมีอยู่ใน wordsDic ให้ +1 ค่า Value
ถ้าคำไม่อยู่ใน wordsDic ให้เพิ่มคำใหม่ (Value เป็น 1)
4. หาคำที่มากที่สุด: หลังจากวนลูปเสร็จแล้ว sort wordsDic ด้วย Value (มากไปน้อย) และแสดงผลคำที่เจอเยอะที่สุด
<br />


# Q2_RomanToInteger
การทำงานของฟังก์ชัน RomanToInteger หลังรับค่า Roman (string):
1. romanNumerals: ใช้เก็บค่าของตัวเลขโรมันแต่ละตัว โดย Key เป็นตัวอักษรโรมันและ Value เป็นตัวเลข
2. คำนวณค่า sum : loop จากขวาไปซ้ายใน roman:
   - ถ้า currentValue น้อยกว่า prevValue ให้ sum - currentValue
   - ถ้า currentValue >= prevValue ให้ sum + currentValue
<br />


# Q3_FindPairs - Logic
การทำงานของฟังก์ชัน FindPairs หลังรับค่า [] numbers และ target:
1. read HashSet<int>: เก็บตัวเลขที่อ่านแล้ว
2. loop : อ่าน numbers:
   - คำนวณตัวเลขเพื่อให้บวกได้ target (find = target - num)
   - ถ้าค่า find มีอยู่ใน read แสดงว่าเราเจอคู่ที่บวกกันได้ target ดังนั้นจึงเพิ่มคู่ (find, num) ลงใน pairs และลบ num ออกจาก read (เพื่อไม่ให้ใช้ซ้ำ)
   - ถ้าไม่พบคู่ใน read ให้เพิ่มตัวเลข num ลงใน read
<br />
<br />
ขอบคุณที่สละเวลาในการตรวจโค้ดของผมครับ 😊🙏🏼
