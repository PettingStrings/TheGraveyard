using System;
using System.Collections.Generic;//Liste
using System.Drawing;//Bitmap,Size
using System.IO;
using System.Text;

namespace SADGames.Classes.Animation
{
    
    public class ClsAnimation
    {

        #region No

        private static Bitmap ErrImg()
        {
            string a = @"ff d8 ff e0 00 10 4a 46 49 46 00 01 01 00 00 01
00 01 00 00 ff db 00 84 00 09 06 07 11 0f 12 0f
10 10 10 10 10 15 15 10 16 15 15 0f 15 0f 12 15
15 15 16 17 15 17 16 16 18 15 16 1d 1f 28 20 18
1b 28 20 15 16 2d 3d 21 25 29 2b 2e 32 2e 1a 1f
36 38 33 31 37 28 2d 2e 2b 01 0a 0a 0a 0e 0d 0e
1b 10 10 1a 2f 25 20 25 2f 2d 2d 30 36 32 2d 2d
2e 38 35 32 2d 2d 2d 2d 2d 2d 2d 2d 2d 2d 2d 2d
2d 2d 2d 2d 2d 35 2b 2d 2d 35 2d 2d 2d 2d 2f 2d
2d 2d 2d 2d 2d 2f 2b 35 35 2d ff c0 00 11 08 00
e0 00 e1 03 01 11 00 02 11 01 03 11 01 ff c4 00
1c 00 01 00 02 03 01 01 01 00 00 00 00 00 00 00
00 00 00 02 07 01 05 06 03 04 08 ff c4 00 42 10
00 02 01 02 01 09 03 08 06 09 05 01 00 00 00 00
01 02 00 03 04 11 05 06 12 21 31 41 51 61 71 07
22 91 13 42 52 72 81 92 a1 b1 14 23 32 54 62 c1
16 33 53 63 73 82 a2 d1 e1 b2 c2 c3 e2 f0 15 ff
c4 00 1b 01 01 00 02 03 01 01 00 00 00 00 00 00
00 00 00 00 00 01 02 04 05 06 03 07 ff c4 00 34
11 00 02 01 02 04 03 04 0a 02 03 01 01 00 00 00
00 00 01 02 03 11 04 05 21 31 12 41 51 13 22 61
71 14 32 81 91 a1 b1 c1 d1 e1 f0 06 52 15 42 53
72 23 ff da 00 0c 03 01 00 02 11 03 11 00 3f 00
bc 60 08 02 01 82 70 d6 75 73 80 95 ce 3f 2f 76
8d 67 6d 8a 52 26 e9 c6 ea 64 68 03 ce a6 cf 77
19 8d 53 15 08 e8 b5 37 b8 3f e3 f8 9a fd e9 f7
17 8e fe ef bd 8e 17 29 f6 93 7f 5b 11 4c d3 b7
5e 08 81 9b 0e 6c d8 fc 00 98 92 c5 54 7b 68 74
58 7f e3 d8 3a 7e ba 72 7e 2f e8 ad f5 39 db 9c
b7 75 57 1f 29 75 70 f8 ee 35 9f 0f 0c 70 13 c5
ce 4f 76 cd a4 30 78 7a 7e ad 38 af 62 3e 16 62
76 92 79 93 8c a1 90 92 5b 11 82 44 01 00 40 10
04 01 00 40 10 04 01 00 40 32 0e 1b 35 40 3e cb
7c af 73 4f f5 77 37 09 ea d6 a8 3f 39 65 39 2d
9b 3c 27 85 a1 3f 5a 11 7e 69 1b fc 9b da 26 50
a3 86 95 45 ae be 8d 54 18 fb cb 81 f1 c6 7b 47
13 52 3c ee 6b 2b e4 18 2a bb 47 85 f8 3f a3 ba
3b 7c 85 da 6d ad 6c 16 e1 5a d5 8f 9c 4e 9d 33
fc c0 62 be d1 87 39 95 4f 17 17 a4 b4 39 fc 5f
f1 cc 45 2e f5 17 c6 bd cf dd cf df ec 3b 7a 55
55 d4 32 32 b2 91 88 65 20 82 38 82 36 cc a4 ef
b1 cf ca 32 8b e1 92 b3 27 24 a8 80 20 08 02 00
80 6b 72 f6 5c a1 63 48 d5 ae d8 0d 8a 83 5b b9
f4 54 6f 3f 0e 32 95 2a 46 0a ec cb c1 e0 aa e2
ea 76 74 97 9b e4 bc ca 67 3a 73 ce e7 28 12 a4
9a 34 77 50 53 a8 ff 00 11 bc f3 cb 67 29 ac ab
5e 55 3c 8e f3 2f ca 28 60 d5 d2 bc fa bf a7 4f
9f 89 a8 c9 79 26 bd d1 d1 a3 4c be 1b 5b 62 2f
56 3a 87 4d b3 ca 30 94 b6 46 6e 23 15 4a 82 bd
49 5b e7 ee 3a cb 0e cf c6 18 dc 57 3e a5 21 b3
f9 d8 6b f7 66 4c 70 df d9 9a 5a d9 eb da 94 3d
ff 00 65 f7 37 34 73 3e c5 30 fa 92 fc da ad 43
e2 01 03 e1 3d 15 08 2e 46 04 b3 6c 5c bf da de
49 7d 8f a3 f4 76 cb ee d4 bc 25 bb 28 74 3c fd
3f 15 ff 00 46 44 e6 fd 9f dd a9 7b b2 3b 28 74
27 d3 f1 5f f4 64 4e 6f d9 fd da 97 bb 1d 94 3a
13 e9 d8 9f fa 32 27 20 5a 7d da 97 bb 23 b2 87
42 7d 3b 13 fd d9 13 90 6d 3e ef 4b dd 8e ca 1d
09 f4 ec 4f f7 64 4e 41 b4 fb bd 2f 76 3b 28 74
2d e9 d8 9f ee c8 9c 85 69 f7 7a 5e ec 8e ce 1d
09 f4 dc 4f f7 64 4e 43 b4 fb bd 3f 76 3b 38 74
27 d3 71 1f dd 90 39 12 d7 ee f4 fd d8 ec e1 d0
9f 4c c4 7f 76 44 e4 4b 5f d8 53 f0 91 d9 c3 a1
6f 4c c4 7f 76 44 e4 5b 5f d8 53 f0 8e ce 1d 09
f4 cc 47 f7 64 4e 46 b5 fd 85 3f 09 1d 9c 3a 13
e9 78 8f ee c8 9c 8f 6d fb 0a 7e 11 d9 c3 a1 3e
97 5f fb b2 0f 91 ad 8e af 20 9e cc 47 c4 18 ec
e3 d0 b2 c5 d7 5f ee cd 7d d6 6c 51 6f d5 b3 d3
3c 31 d2 5f 03 af e3 28 e8 ae 46 55 3c ca aa f5
92 7f 0f df 71 a3 be c8 75 a8 e2 70 f2 8b e9 2e
bc 3a ae d1 3c a5 4d a3 61 47 1b 4a a6 9b 3f 13
59 3c cc b3 75 9b 79 cf 73 93 d8 1a 2f 8a 63 8b
50 6d 68 de cf 34 f3 1f 1d 93 d6 9d 59 53 7a 18
18 ec b6 86 32 36 a8 b5 e4 d6 ff 00 9f 26 5d 19
ad 9c f4 32 8d 3d 2a 47 45 d7 ed d1 62 34 97 9f
e2 5e 63 e0 75 4d 9d 2a d1 a8 b4 38 2c c3 2d ab
82 9d a7 aa 7b 3e 4f ec fc 0d dc f5 35 e2 00 80
20 1a dc e0 cb 54 ac 68 bd 7a c7 50 d4 a8 36 bb
1d 8a bc f5 78 02 77 4a 54 a8 a1 1b b3 2f 05 83
a9 8b aa a9 53 f6 f8 2e ac a1 b2 fe 5b ad 7d 55
ab 56 6c 4e c5 41 f6 51 77 2a 8e 1c f7 cd 45 4a
8e 6e ec fa 3e 0f 07 4b 0b 49 53 a6 bc fc 5f 56
6f f3 67 33 8d 40 b5 ae 81 54 3a d6 8e b0 cd cd
ce d5 1c b6 f4 df ed 4a 85 f5 91 ac c7 e6 dc 0d
d3 a1 bf 37 f6 eb f2 3b ca 48 b4 d4 22 2a a2 81
80 55 00 01 d0 09 96 92 5a 23 9c 93 94 df 14 9d
d9 92 f0 2c 40 bc 13 62 25 a4 16 b1 02 d0 4d 88
97 90 4d 88 17 82 d6 22 5e 41 36 20 5e 0b 58 89
78 26 c4 0b 48 b9 6b 11 2d 04 d8 81 79 05 ac 44
bc 13 62 05 e4 16 b1 12 f0 4d 88 16 82 d6 22 5e
45 c9 b1 02 f0 5a c6 9f 2b 64 85 ab 8b a6 08 fe
01 ba f0 3c e7 94 e9 a7 aa 33 b0 d8 b9 53 ee cb
55 f2 39 67 42 a4 82 08 20 e0 41 dc 66 39 b8 4d
35 74 7d 19 37 28 55 b6 a8 95 a8 b9 47 53 88 61
f1 04 6f 07 84 b4 64 e2 ee 8f 3a f4 29 d7 a6 e9
d4 57 4c bd b3 43 39 69 e5 1a 3a 6b 82 d4 5c 05
5a 58 fd 96 dc 47 e1 38 1c 0f 5e 13 6b 46 aa a9
1b f3 3e 73 99 e5 d3 c1 55 e1 7a c5 ec fa fe 57
33 7b 3d 8d 70 80 60 9c 35 98 05 11 9f 99 c8 6f
ee 0e 89 fa 9a 64 ad 21 c7 d2 7e ad 87 86 1c e6
a6 bd 5e d2 5e 07 d1 f2 8c bd 60 e8 6b eb cb 57
f6 f6 7c ee 7d 99 93 9b e1 f0 ba ac b8 a8 3f 54
87 ce 23 cf 23 80 dd cf 5f 0c 6d 42 95 fb cc c7
cd 71 ee 3f fc 69 bd 79 fd be e7 74 5e 65 9c ed
88 96 82 d6 22 5a 41 36 20 5e 09 b1 02 f2 0b 58
89 78 26 c4 0b c8 2d 62 25 e0 9b 10 2d 22 e5 ac
44 b4 13 62 25 e4 16 b1 02 f0 4d 88 17 90 5a c4
4b c1 36 20 5e 0b 58 89 79 17 26 c4 0b c1 36 22
5e 41 6b 10 2f 05 ac 44 bc 82 6c 40 bc 16 b1 a3
ce 1b 60 40 aa 36 ea 0d cc 6e 3f 97 84 f1 a8 b9
9b 0c 15 47 ea 3f 61 a2 9e 46 c4 db 66 c6 5c 7b
0b 84 ae 98 91 f6 6a 27 a6 84 f7 87 5d e3 98 13
d2 95 47 4e 5c 48 c2 c7 e0 a1 8b a0 e9 4b 7e 4f
a3 fd df c0 fd 05 6b 70 95 51 2a 53 60 ca ea 19
58 6f 04 62 0c dc 26 9a ba 3e 67 52 9c a9 cd c2
4a cd 68 cf 59 25 0e 3b b5 0c b5 f4 6b 43 4d 0e
0f 5c 9a 63 88 4c 3e b0 f8 10 3f 9a 63 62 aa 70
c2 cb 99 bd fe 3f 83 ed f1 3c 72 5a 43 5f 6f 2f
bf b0 a8 f2 16 4e 37 35 92 96 c1 b5 c8 dc 83 6f
e4 3a 91 35 d0 8f 14 ac 76 d8 bc 47 61 49 cf 9f
2f 3f dd 4b 55 00 50 15 40 50 00 01 46 c0 06 a0
04 d8 6c 71 ae f2 77 7b b3 05 e0 58 89 79 05 ac
40 bc 13 62 25 e4 16 b1 02 f0 4d 88 96 91 72 d6
20 5a 09 b1 12 f2 09 b1 02 f0 5a c4 4b c8 2d 62
05 e0 9b 11 2f 05 ac 40 b4 82 6c 44 bc 13 62 05
e4 16 b1 12 f0 5a c4 0b c8 26 c4 0b c1 36 22 5a
41 6b 11 2f 04 d8 81 79 05 ac 7c 99 48 e3 4a a7
aa 7f c4 ac b6 3d a8 2b 54 89 cc 4f 03 6e 20 16
cf 64 19 6b 4e 95 5b 37 3a e9 77 e9 ff 00 0d 8f
78 0e 8c 7f ac 4d 86 0e a5 d3 83 e4 71 7f c9 70
7c 15 23 88 8e d2 d1 f9 ad bd eb e4 58 93 34 e5
ca 57 b5 6c a3 e5 af 8d 30 7b b4 69 aa 61 bb 49
86 9b 1f 8a 8f e5 9a bc 54 af 52 dd 0e ff 00 f8
ee 1f b3 c1 f1 f3 93 6f d8 b4 5f be 27 a6 61 5a
68 d3 ab 58 ed 76 d1 1e aa ed c3 a9 3f d3 27 0e
b4 6c f3 ce 2a f1 4e 34 d7 2d 7d af f1 f3 3a 92
f3 20 d4 58 81 79 05 ac 40 bc 13 62 25 e4 5c 9b
10 2d 05 ac 44 bc 81 74 88 17 8b 92 9a 64 4b c8
2f 62 05 e0 b5 88 97 82 6c 40 b4 8b 96 b1 12 f0
4d 88 17 90 5a c4 4b c1 36 20 5e 41 6b 11 2f 04
d8 81 69 05 ac 44 b4 10 e5 15 b9 02 f2 2e 14 e2
f9 91 2f 07 ad 88 17 90 5a c4 4b c1 36 35 79 5e
ec 61 e4 c1 d6 7e d7 21 b7 0e b3 ce 72 e4 66 61
a9 6b c6 cd 44 f3 33 44 03 7f 98 99 47 e8 d7 d6
af 8e 01 9f c9 37 4a 9d dd 7d 09 53 ec 9e b4 25
c3 51 33 5b 9b e1 fb 7c 1c e3 cd 2b af 66 bf 2d
0b fa 6e 0f 9a 9f 9c b3 86 e3 ca dd 5d d4 c7 1d
2b 8a 87 d9 a6 70 f8 61 34 b5 1d e6 df 89 f5 3c
14 3b 3c 3d 38 f4 8a f9 1d d6 6f a0 4b 6b 70 37
d3 0d ed 6e f1 ff 00 54 cb a7 a4 11 ce e3 5f 16
22 6f c6 de ed 0f b8 bc b5 cc 6b 11 2d 05 ac 40
bc 82 6c 44 bc 16 b1 02 f2 2e 79 4e 5c 91 b6 c9
59 06 ad c0 0e 4f 93 43 b1 88 c4 b7 aa 38 73 9e
90 a6 e5 a9 83 5b 15 0a 6e cb 56 6e 3f 44 a8 e1
fa ca b8 f1 c5 30 f0 d1 fc e7 af 60 ba 98 9f e4
27 7d 97 c7 ee 68 b2 ce 41 ab 6e 0b 83 e5 13 7b
01 81 5f 58 70 e7 3c a7 4d c7 53 65 84 c7 42 a3
e1 7a 33 48 5e 79 1b 3b 11 2f 20 b5 88 17 82 6c
40 bc 82 d6 22 5e 09 b1 02 d2 0b 58 89 68 26 c7
cf 56 f6 9a ed 74 1c b4 86 3e 12 ae 48 f5 8d 19
bd 93 36 f9 b7 91 aa 5f e2 d4 ce 8d 30 70 35 99
4e 18 ef 08 35 69 9f 87 39 eb 4e 9b a9 b6 c6 b7
1f 8d 8e 17 ba fd 6e 9f bb 1d 6a e6 1d be 1a eb
57 27 88 34 c0 f0 d1 3f 39 91 e8 d1 ea cd 1b cd
6a df 48 af 8f dc e7 73 93 34 6e 2d 94 d5 a0 3e
94 80 62 c8 3b b5 00 e4 ba f4 fd 9a f9 4f 1a 94
25 1d 63 a9 9f 84 cc 29 55 7c 35 3b af e1 f8 fd
d4 e1 4e 59 27 62 0f 7f fc 4c 3e d3 c0 e8 29 52
e1 76 6f 42 07 2b b7 a0 3d e3 fd a4 f1 99 de 8a
ba 9e 15 72 8d 46 d5 88 5e 83 f3 95 72 67 ac 70
f0 5e 27 cb 2a 7b 18 80 20 19 57 2a 43 03 81 07
10 78 11 ac 40 b2 7a 32 f9 fd 2a 4f c3 e3 36 dd
b2 3e 73 fe 2e 45 0d 51 b1 24 f1 24 f8 cd 49 f4
64 ad a1 65 d8 9c 29 51 03 75 24 1f d2 26 74 76
47 25 55 5e a4 9f 8b f9 9e a5 e4 95 b1 02 f0 4d
88 97 90 5a c4 0b c0 6a c8 d9 66 ed 88 b8 ac 15
b5 aa 8d 26 1c 40 c3 01 ed 24 7b 31 96 a7 1e 29
1a dc 55 57 4e 9d d6 ef 42 c2 02 66 9a 11 00 c1
18 ea 3a f9 40 38 4c e9 cd f3 43 1a d4 46 34 fc
e5 fd 9f fd 7e 53 12 ad 2e 1d 56 c7 41 97 e3 d4
ff 00 f9 d4 df 91 cc 17 9e 06 ea c4 4b 48 26 c7
85 7b 95 41 8b 30 5e a7 e4 37 c8 6d 2d cf 48 53
94 bd 54 6b 6b e5 d4 1f 61 4b 73 3d d1 fd fe 12
8e a2 e4 65 c3 05 27 eb 3b 1f 05 6c af 55 b6 10
9d 07 e6 71 94 73 66 4c 70 94 d6 fa 9f 15 4a ac
df 69 99 ba b1 32 ad dc f7 8c 63 1d 91 d4 66 36
67 3e 50 7f 29 53 14 b7 56 ef 3e c3 50 8d a8 9f
9b 6e eb b3 22 85 07 37 77 b1 a3 ce 33 78 e1 a3
d9 d3 d6 6f e0 5d b6 b6 e9 49 16 9d 35 54 45 50
aa 8a 30 00 0d 80 09 b3 49 25 64 70 73 9c a7 27
29 3b b6 7a c9 2a 20 14 ff 00 6a b9 ba b6 d5 52
ea 92 85 4a cc 43 a8 d8 2a e0 5b 11 eb 00 4f 55
3c 66 bb 17 4b 85 f1 2e 67 57 92 e3 1d 58 3a 53
de 3b 79 7e 3f 76 38 33 30 ce ae 84 af 04 62 0f
61 00 40 10 04 03 ec ff 00 e8 bf a4 7c 65 b8 99
e3 d8 43 a1 f1 99 53 d9 16 35 a3 7d 5d 2f e1 af
fa 44 cd 5b 23 96 a8 bb f2 f3 7f 32 65 e4 95 b1
12 d2 09 b1 12 f0 5a c4 0b c8 25 c6 ea c7 53 98
2c 34 ae 38 e8 a6 1d 31 6c 7f 29 ef 87 dd 9a 1c
cd 34 a3 ed fa 1d 94 ca 35 02 00 80 61 80 20 82
31 07 68 80 57 39 e9 90 be 88 1a e6 92 b1 a3 b5
90 0c 4d 3f fa f3 dd d2 61 56 a5 c3 de 5b 1d 36
57 8e ed 9a a3 51 eb c9 95 e5 d6 59 76 d4 9d c1
c7 6b 78 ee 98 6e a3 7b 1d 5d 3c 24 23 ac b5 35
ac c4 9c 49 24 f1 27 13 e3 3c cc a4 92 56 46 20
91 00 ea f3 1b 33 df 28 3f 94 a9 a4 96 ea 7b cf
b0 d4 23 cc 43 f3 6d dd 76 64 d0 a0 e6 ee f6 34
39 be 6f 1c 2c 7b 3a 7a cd fc 0b b6 d6 d9 29 22
53 a6 aa 88 aa 15 50 0c 00 03 70 9b 34 92 56 47
07 39 ca 72 72 93 bb 67 ac 92 a2 00 80 71 3d ae
d4 51 62 14 ed 6b 8a 61 7a 80 cc 7e 01 bc 66 2e
2d ae cc dc 64 71 6f 13 75 c9 3b fe f9 94 cc d6
1d fd 18 f0 c1 23 10 7a 88 02 00 80 20 08 00 c0
3b fb 56 fa ba 7f c3 5f f4 89 98 b6 39 aa 8b be
fc d9 32 f0 56 c4 4b c1 6b 10 2f 04 d8 89 79 05
ac 7d b9 0f 2a 9b 5a cb 53 6a fd 97 51 b4 a9 db
87 3d 40 fb 25 a1 3e 19 5c c3 c6 e1 3b 7a 6d 2d
cb 42 da e1 2a aa d4 a6 c1 95 86 21 86 f9 9e 9a
6a e8 e4 e7 07 09 38 c9 6a 7a c9 2a 20 08 06 19
41 04 10 08 23 02 08 c4 11 ce 09 4e da a2 9d ed
03 32 0d a1 6b 9b 65 26 81 38 bd 31 ac d1 27 87
ee fe 5d 36 6b b1 18 7e 1e f4 76 3b 4c 9b 39 ed
6d 46 b3 ef 72 7d 7f 3f 33 85 98 67 4e 20 1d 56
63 e6 7b e5 17 d3 7d 24 b7 53 de 7d 85 c8 f3 10
fc ce ee bb 32 68 50 73 77 7b 1a 2c df 37 8e 16
3d 9d 3d 66 fe 05 dd 6b 6c 94 51 29 d3 55 44 55
01 50 0c 00 03 70 9b 34 92 56 47 05 39 ca 72 72
93 bb 67 ac 92 a2 00 80 46 a3 85 05 98 85 00 12
58 9c 00 03 59 24 ee 10 4a 4d bb 22 8f ed 07 39
c6 50 ae 05 22 7c 8d 2c 45 33 ac 69 93 86 93 e1
c3 50 03 90 e7 84 d5 62 2b 76 92 b2 d9 1d e6 4b
95 bc 3d 3e 3a 9e b3 fd 4b f7 e8 72 93 1c df 88
02 00 80 20 08 02 00 30 0e e6 d9 bb 94 fd 45 f9
09 96 b6 39 e9 ae fb f3 64 8b c1 16 20 5a 09 b1
12 d2 09 b1 12 f0 5a c4 0b c8 26 c6 e3 36 b3 8d
ac df 03 8b 52 63 de 4d e3 f1 2f 3e 5b e7 a5 3a
ae 0f c0 d7 63 f2 e5 5e 3c 51 f5 91 67 da dc 25
54 5a 94 d8 3a b0 c4 30 d8 66 7a 69 ab a3 93 9c
25 09 38 c9 59 a3 d6 49 51 00 40 30 ea 08 20 80
41 18 10 46 20 83 b8 88 25 3b 6a 8a 77 b4 0c c8
36 85 ae 6d 94 9a 04 e2 c8 35 9a 24 ff 00 c7 f2
e9 35 d8 8c 3f 0f 7a 3b 1d a6 4d 9c f6 b6 a3 59
f7 b9 3e bf 93 5f 98 f9 9e f9 45 f4 df 14 b7 56
ef 3e c2 e4 79 89 f9 9d dd 76 52 85 07 51 dd ec
65 66 f9 bc 70 b1 e0 a7 ac df c3 c4 bb ad 2d 92
8a 25 3a 6a a8 8a a0 2a 01 80 00 70 9b 34 92 56
47 05 39 ca 72 72 93 bb 67 ac 92 a2 00 80 46 a3
85 05 98 85 00 12 58 9c 00 03 59 24 ee 10 4a 4d
bb 22 9a cf fc f6 37 a4 db db 92 b6 e0 f7 9b 61
ac 46 f3 c1 38 0d fb 4e e1 35 b8 8c 47 17 76 3b
1d b6 4d 93 2a 29 56 ac bb dc 97 4f c9 c4 cc 43
a5 10 04 01 00 40 10 04 01 00 18 07 65 6e dd c4
f5 17 e4 26 4a d8 d1 4d 77 9f 9b 24 5e 49 16 20
5e 41 36 22 5e 0b 58 81 79 04 d8 89 78 2d 63 55
7d 94 bc da 67 ab ff 00 6f ef 3c e5 3e 86 65 2c
3f 39 1b 3c c9 ce fa 99 3a a6 8b 69 54 a0 ed 8b
d3 da 54 9f 3d 39 f1 1b fa cf 4a 15 dd 37 67 b1
af cd b2 88 e2 e3 c7 0d 26 be 3e 0c bb ec ee a9
d6 44 ab 49 c3 a3 ae 2a e0 ea 22 6d 13 4d 5d 1c
15 4a 72 a7 27 19 2b 34 7b 49 28 20 08 06 1d 43
02 08 04 11 81 04 62 08 3b 41 10 4a 76 d5 1e 76
b6 c9 49 16 9d 34 54 45 18 2a 28 00 01 c8 48 49
25 64 4c e7 29 c9 ca 4e ed 9e b2 4a 88 02 01 17
70 a0 b3 10 a0 02 4b 13 80 00 6d 24 ee 10 4a 4d
bb 22 9b cf fc f6 37 a5 ad ed c9 5b 70 7b cd b0
d6 23 e4 9c 06 fd a7 74 d6 e2 31 1c 5d d8 ec 76
d9 36 4c a8 a5 5a b2 ef 72 5d 3f 27 11 31 0e 94
40 10 04 01 00 40 10 04 01 00 40 3a ba 0f dc 4f
51 7e 42 64 2d 8d 34 d7 79 f9 99 2f 04 58 89 78
2d 62 05 e4 5c 9b 11 67 82 c9 1a 8b eb e2 fd d5
d4 bb cf 1f f1 3c e5 2b 99 b4 68 f0 ea f7 3e 19
43 20 40 3a 8c c8 ce f7 c9 cf a2 da 4f 6e ed df
a7 b4 a9 f4 e9 f3 e2 37 f5 99 14 2b ba 6e cf 63
47 9b e5 11 c5 c7 8e 1a 4d 7c 7c 19 77 d9 dd 25
64 4a b4 9d 5d 1d 71 57 07 10 44 da 26 9a ba 38
29 c2 54 e4 e3 25 66 8f 69 25 04 01 00 40 10 04
02 2e e1 41 66 20 00 31 24 9c 00 03 69 27 70 82
52 6d d9 14 de 7f e7 b1 bd 2d 6d 6c c4 5b 83 de
7d 86 b1 1f 24 e5 bf 69 dd 35 b8 8c 47 17 76 3b
1d b6 4d 93 2a 29 56 ac bb dc 97 4f c9 c4 4c 43
a5 10 04 01 00 40 10 04 01 00 40 10 04 03 a4 a2
dd d5 f5 47 ca 7b ad 8d 54 97 79 99 2f 04 58 89
79 05 ac 40 bc 13 63 57 7b 77 a7 dd 5d 9c 78 ff
00 89 e7 29 5c cc a5 4b 87 57 b9 f1 ca 9e e2 00
80 20 1d 46 64 67 7b e4 e7 d0 7d 27 b7 76 ef d3
da 50 fa 74 f9 f1 1b fa cc 8a 15 dd 37 67 b1 a3
cd f2 88 e2 a3 c7 0d 26 be 3e 0c bb ec ee 92 b2
25 5a 4e ae 8e 31 57 07 10 44 da 26 9a ba 38 29
c2 50 93 8c 95 9a 3d a4 94 10 04 01 00 8b b8 50
59 88 00 0c 49 27 00 00 da 49 dc 20 94 9b 76 45
39 da 06 7b 1b c2 d6 d6 cc 45 b8 3d e7 d8 6b 11
fe ce 5b f6 cd 6e 23 11 c5 dd 8e c7 6b 93 64 ca
8a 55 ab 2e f7 25 d3 f2 70 f3 10 e9 84 01 00 40
10 04 01 00 40 10 04 01 00 40 37 d4 9f ba be a8
f9 4f 64 6b a4 bb cc 17 81 62 05 e4 13 63 e2 bd
b8 f3 47 b4 fe 52 b2 66 45 2a 7f ec cf 86 50 c8
10 04 01 00 40 3a 8c c8 cd 07 ca 2f a4 da 49 6e
8d df a9 b0 b9 f4 29 f3 e2 77 75 99 14 28 3a 8e
ef 63 47 9b e6 f1 c2 47 82 1a cd fc 3c 59 77 d9
da a5 14 4a 54 91 51 10 60 a8 06 00 09 b4 49 25
64 70 53 9c aa 49 ca 4e ed 9e d2 4a 08 02 00 80
45 d0 30 2a c0 10 46 04 11 88 20 ed 04 6f 10 4a
6d 3b a2 9c ed 03 32 4d 99 6b 9b 65 26 dc 9e f2
6d 34 49 ff 00 67 3d db 0c d6 e2 30 fc 3d e8 ec
76 b9 36 72 ab 25 46 b3 ef 72 7d 7f 27 0f 31 0e
98 40 10 04 01 00 40 10 04 01 00 40 10 04 03 6e
8d a9 7a 0f 94 f4 30 9a d5 82 d0 2c 78 d7 ad a2
39 ee 90 d9 78 42 ec d7 ca 19 46 20 08 02 00 80
75 19 91 9a 0f 94 5f 49 b4 92 dd 0f 7e a6 c2 c7
d0 a7 cf 89 dd d6 64 50 a0 ea 3b bd 8d 1e 6f 9b
c7 09 1e 08 6b 37 f0 f1 65 df 67 6a 94 51 29 52
40 88 83 05 40 30 00 4d a2 49 2b 23 82 9d 49 54
93 94 9d db 3d a4 94 10 04 01 00 40 10 08 ba 06
05 58 02 08 c0 82 31 04 1d a0 8d e2 09 4d a7 74
53 79 ff 00 99 26 c8 b5 cd b8 26 dc 9e f2 6d 34
49 f9 a7 3d db 0e e9 ad c4 61 f8 7b d1 d8 ed b2
6c e5 56 4a 8d 67 de e4 fa fe 4e 22 62 1d 28 80
20 08 02 00 80 20 08 02 00 80 20 1b 05 7d 43 a0
97 31 9a d4 c1 78 16 3e 4a cf 89 95 67 bc 55 91
e7 20 b0 80 20 08 07 4f 99 39 a1 53 28 be 93 62
96 e8 7b f5 37 b1 f4 29 f3 e2 77 75 99 14 28 3a
8e ef 63 49 9b e6 d1 c2 47 82 1a cd fc 3c 59 78
59 da 53 a0 89 4a 92 04 44 5c 15 00 d4 04 da 24
92 b2 38 1a 95 25 52 4e 52 77 6c f6 92 50 40 10
0c 3b 05 04 92 00 03 12 49 c0 00 36 92 60 94 af
a2 3c ed 6e 52 aa 2d 4a 6e ae 8c 31 57 52 08 23
91 90 9a 6a e8 99 c2 50 93 8c 95 9a 3d 64 95 10
04 02 35 10 30 2a c0 30 20 82 a4 62 08 3b 41 1b
c4 12 9b 4e e8 a6 f3 ff 00 32 4d 91 6b 8b 70 5a
dc 9e f2 ed 34 49 e3 c5 38 1d db 0e e3 35 b8 8c
3f 0f 7a 3b 1d b6 4d 9c aa c9 51 ac fb dc 9f 5f
c9 c4 4c 43 a5 10 04 01 00 40 10 04 01 00 40 10
0f a8 36 a1 d2 58 f2 b1 07 7d 52 2e 4a 47 84 83
d0 40 10 04 03 a7 cc 9c d1 a9 94 5f 49 b1 4b 74
6e fd 5d ec 7d 0a 7c f8 9d dd 66 45 0a 0e a3 bb
d8 d2 66 d9 b4 70 91 e0 86 b3 7f 0f 16 5e 16 56
94 e8 22 52 a4 8a 88 83 05 40 35 01 36 89 24 ac
8e 06 a5 49 54 93 94 9d db 3d a4 94 10 04 03 0e
c0 02 49 00 01 89 24 e0 00 e2 60 94 af a2 29 de
d0 33 dc dd 96 b6 b6 62 28 03 83 d4 1a 8d 62 3f
e3 f9 f4 db ae c4 62 38 bb b1 d8 ed 32 6c 9b b2
b5 6a cb bd c9 74 fc 9a fc c7 cf 07 c9 cf a0 f8
bd bb 37 79 36 94 27 cf 4f cc 6f eb b6 94 2b b8
3b 3d 8c ac df 28 8e 2a 3d a5 3d 26 be 3e 05 dd
69 72 95 91 2a 53 65 74 65 05 5c 1c 41 07 84 d9
a6 9a ba 38 29 c2 50 93 8c 95 9a 3d 64 95 10 04
02 35 10 30 2a c0 30 20 82 a4 62 08 3a 88 23 78
82 53 69 dd 14 d6 7f e6 49 b2 26 e2 dc 16 b7 27
5a ed 34 49 dc 78 a7 03 bb 61 dc 66 b7 11 87 e1
ef 47 63 b6 c9 b3 95 59 2a 35 9f 7b 93 eb f9 38
99 88 74 a2 00 80 20 08 02 00 80 20 08 04 f4 a4
95 b1 12 64 16 31 00 40 10 0d ce 69 64 33 7f 73
4e 86 25 57 02 f5 18 6d 14 d7 0d 2c 39 92 40 ea
d3 d6 8d 3e d2 56 35 79 a6 3f d1 68 b9 2d f6 5e
6f f6 e5 fb 65 69 4e 85 34 a5 49 02 22 0c 15 06
c0 3f f6 f9 b7 49 25 64 7c ea a5 49 54 93 9c dd
db 3d e4 94 10 04 03 0c c0 02 49 00 01 89 24 e0
00 e7 01 2b e8 8a 77 b4 0c f7 37 65 ad ad 98 8a
00 e0 f5 06 da c4 70 fd df cf a6 dd 76 23 11 c5
dd 8e c7 6b 93 64 dd 95 ab 56 5d ee 4b a7 e7 e4
70 b3 0c e9 c4 03 aa cc 6c f0 7c 9e fa 0f a4 f6
ec 7b c9 b4 a1 3e 7a 0f 98 df d7 6e 4d 0a ee 0e
cf 63 45 9b e5 11 c5 47 b4 a7 a4 d7 c4 bb ad 6e
52 aa 25 4a 6c ae 8c a0 ab 83 88 20 ef 13 66 9a
6a e8 e0 a7 09 42 4e 32 56 68 f5 92 54 40 10 08
d4 40 c0 ab 00 c0 82 0a 91 88 20 ea 20 8d e2 09
4d a7 74 51 dd a0 e6 c8 c9 f5 c1 a4 3e a6 ae 2d
4c 6d d0 23 0d 24 c7 80 c4 11 c8 f2 c6 6a b1 14
bb 39 69 b3 3b cc 97 33 78 8a 7c 35 3d 65 a7 d9
fe fd 4e 56 63 9b f1 00 40 10 04 01 00 40 10 04
01 00 40 10 0c c1 12 76 4d 96 57 62 d4 d7 4a f9
fc e0 b4 54 0e 00 9a 84 f8 90 3c 26 76 0b fd 8e
27 f9 04 9d a9 af fd 7d 0b 4a 67 9c d0 80 20 18
66 00 12 48 00 0c 49 3b 00 e7 01 2b 94 f7 68 19
ee 6e cb 5b 5b 31 14 01 c1 ea 0d 46 b1 e0 3f 77
f3 e9 b7 5d 88 c4 71 77 63 b1 da e4 d9 37 65 6a
d5 97 7b 92 e9 f9 f9 1c 24 c3 3a 71 00 40 10 0e
af 31 b3 c1 f2 7b f9 3a 9a 4f 6e c7 bc 9b 4d 32
7c f4 1f 35 df d7 6e 4d 0a ee 0e cf 63 43 9b e5
11 c5 47 b4 a7 a4 d7 c4 bb 6d 6e 52 aa 25 4a 6c
1d 19 43 2b 83 88 20 ef 13 66 9a 6a e8 e0 e7 09
42 4e 32 56 68 f5 92 54 40 10 0a ff 00 b6 5c 3e
8b 6d c7 e9 63 0e 9e 4a ae 3f ed 98 98 cf 51 79
9b dc 82 fd bc bf f3 f5 45 47 35 a7 77 4a 5c 50
4c c4 1e 82 00 80 20 08 02 01 27 5c 09 07 71 23
c2 08 4e ea e4 60 91 00 40 10 0c c1 59 ab c5 a3
a6 ec f7 2f ad 8d d0 35 0e 14 aa af 93 a8 77 2e
bc 51 cf 20 7e 0c 4e e9 ef 86 ab c1 3d 76 67 35
9a 61 1e 22 85 a3 eb 2d 57 d5 7e f4 2f 50 71 d6
35 f3 9b 63 8a 33 00 c3 30 00 92 40 00 62 49 d8
04 04 ae 53 dd a0 e7 b9 bb 2d 6b 6a c4 50 07 07
a8 36 d6 3c 07 ee fe 7d 36 eb b1 18 8e 2e ec 76
3b 4c 9b 26 ec ed 5a b2 ef 72 5d 3f 3f 23 84 98
67 50 20 08 02 00 80 20 1d 5e 63 67 8b e4 f7 f2
75 34 9e dd 9b bc 9b 4d 32 76 ba 0f 9a ef eb b7
26 85 77 07 67 b1 a1 cd f2 88 e2 a3 da 53 d2 6b
e2 5d b6 b7 09 55 16 a5 36 57 46 50 55 d4 e2 08
3b 08 33 66 9a 6a e8 e0 e7 09 42 4e 32 56 68 f5
92 54 40 29 9e d5 32 ea dc dc a5 0a 6d a4 96 e1
81 60 75 1a 8c 46 97 5d 1d 10 3a e9 4d 66 2e a7
14 b8 57 23 ae c9 b0 ae 95 17 39 6f 2f 97 2f 7f
d8 e2 66 29 d5 52 56 82 46 20 f4 10 04 01 00 40
3e cf fe 73 fa 27 c2 5b 85 9e 3d bc 3a 9e 99 c3
6f e4 ae ae e9 e1 86 8d c5 41 ec d3 38 7c 30 93
51 5a 6d 78 94 c1 54 ed 30 f4 e5 d6 2b e4 6b e5
0c 91 00 40 10 04 03 30 61 d6 a2 ef c5 13 ac cd
7c fc b9 b1 51 49 80 b8 a2 35 0a 6c c4 32 0e 08
fa f0 1c 88 3c b0 99 14 b1 32 86 8f 54 68 71 99
55 2c 43 e3 5d d9 75 eb e6 be a7 62 bd ab 5a 61
89 b7 bb d2 f4 74 68 91 e3 a7 b3 d9 32 bd 32 1d
19 a9 ff 00 03 5e fe b4 7e 3f 63 8e ce cc fb b8
bf 06 92 af d1 e8 9d b4 c3 62 cf eb b6 ad 5f 84
7b 49 98 d5 71 32 9e 8b 44 6f f2 cc 92 9d 06 aa
4f bc ff 00 76 5f 5f 91 c9 4c 63 a1 10 04 01 00
40 10 04 01 00 e8 73 5b 3b ee 72 76 2a 98 54 a4
4e 26 83 93 86 3b ca 1d a8 7c 47 29 ef 4a bc a9
f9 1a 6c cb 28 a5 8a ef ed 2e ab f7 53 b7 5e d6
68 68 eb b4 ae 1b 80 7a 65 7d ec 41 f8 4c af 4d
8d b6 39 b7 90 54 be 93 56 f6 fe fc 4e 73 38 3b
47 ba ba 56 a7 45 45 aa 1d 44 ab 96 a8 47 af 80
d1 f6 0c 79 cf 0a 98 b9 4b 45 a1 b0 c2 e4 d4 68
be 29 be 27 f0 f7 73 fd d0 e2 e6 29 bf a5 45 c9
dd ec 62 0c e1 00 40 10 04 03 2a 85 88 50 31 24
e0 07 12 75 08 17 4b 56 5f 3f a2 a9 f8 7c 26 db
b1 47 ce 7f ca 48 ae 3b 56 c9 de 46 f8 d4 03 bb
5a 9a be 3b b4 94 68 30 f8 29 fe 69 85 8a 8d aa
5f a9 d4 ff 00 1d c4 76 98 3e 0e 71 6d 7b 1e ab
f7 c0 e3 26 31 bd 10 04 01 00 40 10 0c c1 e7 2a
50 96 e8 40 8d 18 47 64 62 0f 41 00 40 10 04 01
00 40 10 04 01 00 cc 14 95 38 cb 74 20 2a 50 5b
23 10 5c 40 10 04 01 00 40 37 f9 89 93 be 93 7d
6a 98 62 15 fc ab 74 a7 de d7 d4 85 1e d9 eb 42
3c 55 12 35 b9 be 23 b0 c1 ce 5c da b2 f6 e9 f2
d4 bf a6 e0 f9 a9 c7 76 a1 91 7e 93 68 6a 20 c5
e8 13 50 71 29 87 d6 0f 00 0f f2 cc 6c 55 3e 28
5d 72 37 bf c7 f1 9d 86 27 82 4f 49 e9 ed e5 f6
f6 94 9c d5 9d f8 80 20 08 02 00 80 20 08 02 00
80 20 08 02 00 80 20 08 02 00 80 20 08 02 00 80
20 08 02 00 80 5b 3d 90 64 5d 0a 55 6f 1c 6b ab
dc a7 fc 35 3d e2 3a b0 fe 81 36 18 3a 76 4e 6f
99 c5 ff 00 25 c6 71 54 8e 1e 3b 47 57 e6 f6 f7
2f 99 62 4c d3 97 30 46 3a 8c 02 88 cf cc db 36
17 07 44 7d 4d 42 5a 91 e1 e9 27 55 c7 c3 0e 73
53 5e 97 67 2f 03 e8 f9 46 60 b1 94 35 f5 e3 a3
fb fb 7e 77 39 a9 e0 6d 44 01 00 40 10 04 01 00
40 10 04 01 00 40 10 04 01 00 40 10 04 01 00 40
10 04 01 00 40 36 d9 b1 90 de fe e1 28 26 20 7d
aa 8f e8 20 3d e3 d7 70 e6 44 f4 a5 4d d4 97 0a
30 b1 f8 d8 61 28 3a b2 df 92 ea ff 00 77 f0 3f
41 5a db a5 24 4a 74 d4 2a a2 85 55 1b 80 18 01
37 09 24 ac 8f 99 d4 a9 2a 93 73 93 bb 7a b3 d6
49 41 00 d6 e7 06 45 a5 7d 45 e8 56 1a 8e b5 71
b5 18 6c 65 e7 af c0 91 be 52 a5 35 38 d9 99 78
2c 65 4c 25 55 56 9f b7 c5 74 65 0d 97 f2 2d 6b
1a ad 46 b2 e0 76 ab 8f b2 eb b9 94 ff 00 ec 26
a2 a5 37 07 66 7d 1f 07 8c a5 8b a4 aa 53 7e 7e
0f a3 35 b2 86 50 80 20 08 02 00 80 20 08 02 00
80 20 08 02 00 80 20 08 02 00 80 20 08 02 00 80
7d 59 37 27 d5 b9 a8 94 68 a1 77 63 80 51 f1 24
ee 03 8c b4 62 e4 ec 8f 2a f5 e9 d0 a6 ea 54 76
48 bd b3 43 36 a9 e4 ea 3a 0b 83 54 6c 0d 5a b8
7d a6 dc 07 e1 18 9c 07 5e 33 6b 46 92 a7 1b 73
3e 73 99 e6 33 c6 d5 e2 7a 45 6c ba 7e 5f 33 7b
3d 8d 70 80 20 08 06 b7 2f 64 3a 17 d4 8d 1a eb
88 da ae 35 3a 1f 49 4e e3 f0 e3 29 52 9c 66 ac
cc bc 1e 36 ae 12 a7 69 49 f9 ae 4f cc a6 73 a7
33 2e 72 79 2c 41 ad 47 75 75 1a 87 f1 17 cc 3c
f6 73 9a ca b4 25 4f c8 ef 32 fc de 86 31 59 3b
4f a3 fa 75 f9 f8 1c d4 f0 36 a2 00 80 20 08 02
00 80 20 08 02 00 80 20 08 02 00 80 20 08 02 00
80 20 1b ac db cd 8b 9c a0 c0 51 4c 13 1c 1a bb
6a 45 f6 f9 c7 90 f8 6d 9e b4 e9 4a a3 d0 c0 c7
66 54 30 71 bd 47 af 24 b7 fc 79 b2 e8 cd 6c d8
a1 93 a9 e8 d2 1a 4e df 6e b3 01 a4 dc bf 0a f2
1f 13 ae 6c e9 51 8d 35 a1 c1 66 19 95 5c 6c ef
3d 12 d9 72 5f 77 e2 6e e7 a9 af 10 04 01 00 40
10 0c 11 8e a3 af 94 04 ec 71 f9 7b b3 9b 3b 9c
5e 90 36 ae 77 d3 03 40 9e 74 f6 7b b8 4c 6a 98
58 4b 55 a1 bd c1 ff 00 20 c4 d0 ee cf be bc 77
f7 fd ee 70 b9 4f b3 6b fa 38 9a 62 9d c2 f1 47
0a d8 73 56 c3 e0 4c c4 96 16 a2 db 53 a2 c3 ff
00 21 c1 d4 f5 db 8b f1 5f 55 7f a1 ce dc e4 4b
aa 58 f9 4b 5b 84 c3 79 a2 f8 78 e1 81 9e 2e 12
5b a6 6d 21 8c c3 d4 f5 6a 45 fb 51 f0 b2 91 b4
11 c8 8c 25 0c 84 d3 d8 8c 12 20 08 02 00 80 20
08 02 00 80 20 08 02 01 90 31 d9 ae 01 f6 5b e4
8b 9a 9f ab b6 b8 7f 56 8d 43 f9 4b 28 49 ec 99
e1 3c 55 08 7a d3 8a f3 68 df e4 de ce f2 85 6c
34 a9 ad 05 f4 aa b8 c7 dd 5c 4f 8e 13 da 38 6a
92 e5 63 59 5f 3f c1 52 da 5c 4f c1 7d 5d 91 db
e4 2e cc ad 68 e0 d7 0c d7 4c 3c d2 34 29 8f e5
07 16 f6 9c 39 4c aa 78 48 ad 65 a9 cf e2 ff 00
91 e2 2a f7 68 ae 05 ef 7e fe 5e ef 69 db d2 a4
a8 a1 51 55 54 0c 02 a8 00 01 c0 01 b2 65 25 6d
8e 7e 52 94 9f 14 9d d9 39 25 44 01 00 40 3f ff
d9
";
            byte[] bytes = Convert.FromBase64String(a);
            MemoryStream mem = new MemoryStream(bytes);
            Bitmap img = (Bitmap)Bitmap.FromStream(mem);
            return img; 
        
        }

        public static Bitmap ErrorBitmap;
        #endregion
        #region Variables

        List<Bitmap> frames = new List<Bitmap>();

        #endregion

        #region Properties
        public int FramesLenght { get => frames.Count; }

        #endregion

        #region Methods

        public ClsAnimation() { }

        /// <summary>
        /// Controlla che INDEX sia accettabile, per poi
        /// ritornare il frame in posizione INDEX e aumentare
        /// di uno INDEX
        /// </summary>
        /// <param name="INDEX">Posizione Del Prossimo Frame</param>
        /// <returns>Il frame in posizione INDEX</returns>
        public Bitmap GetNextFrame(ref int INDEX)
        {
            if (this.frames == null)
                return ErrorBitmap;
            if (this.frames.Count == 0)
                return ErrorBitmap;

            if (INDEX < 0 || INDEX >= frames.Count)
                INDEX = 0;

            Bitmap temp = new Bitmap(frames[INDEX]);

            INDEX++;

            return temp;
        }
        /// <summary>
        /// Stessa cosa di GetNextFrame(...),
        /// solo che in questo caso specchia il frame
        /// sull'asse X
        /// <seealso cref="GetNextFrame(ref int)"/>
        /// </summary>
        /// <param name="INDEX">Posizione del frame da prendere</param>
        /// <returns>Frame in posizione INDEX</returns>
        public Bitmap GetNextFlippedXFrame(ref int INDEX)
        {
            Bitmap temp = GetNextFrame(ref INDEX);
            temp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            return temp;
        }
        /// <summary>
        /// Aggiunge un frame
        /// (ora uso una lista, in teoria non ci sarebbe bisogno di questa funzione,
        /// ma la lascio nel caso voglia ad esempio mettere un limite o qualche altra cosa)
        /// </summary>
        /// <param name="PATH">Posizione in cui prendere l'immagine</param>
        public void AddFrame(string PATH)
        {
            frames.Add(new Bitmap(PATH));
        }
        /// <summary>
        /// Aggiunge un frame, ma ridotto secondo una scala
        /// </summary>
        /// <param name="PATH">Posizione del frame</param>
        /// <param name="scaling">Rapporto di ingrandimento/rimpicciolimento</param>
        public void AddFrame(string PATH,float scaling)
        {
            //Non c'era un costruttore (path,size) ma solo (image,size)
            Bitmap temp = new Bitmap(PATH);
            temp = new Bitmap(temp,new Size(
                (int)(temp.Width * scaling),
                (int)(temp.Height * scaling)
                ));
            frames.Add(temp);
        }

        public void AddFrame(Bitmap frame)
        {
            //Non c'era un costruttore (path,size) ma solo (image,size)
            Bitmap temp = new Bitmap(frame);
            frames.Add(temp);
        }
        /// <summary>
        /// Rimuove un frame
        /// </summary>
        /// <param name="INDEX"></param>
        public void RemoveFrame(int INDEX)
        {
            frames.RemoveAt(INDEX);
        }

        #endregion
    }
}
