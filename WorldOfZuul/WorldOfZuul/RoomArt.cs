using System;

public class RoomArt
{
    public static void Main2() //! Had to rename this, becasue of error code (cant use 2 Mains..)
    {
        // Actually is 86 characters wide and 26 characters tall because of the newline at the start and end
/* string room1 = @"
┌────────────────────────────────────────────────────────────────────────────────────┐
│                                                |>>>                                │
│                                                |                                   │
│                                            _  _|_  _                               │
│               _///_                       |;|_|;|_|;|                              │
│              /o    \/                     \\.    .  /                              │
│              > ))_./\                      \\:  .  /                               │
│               \/                            ||:   |                    ><^,>       │
│                       .--._.--.             ||:.  |                                │
│                      ( O     O )            ||:  .|        ><^,>                   │
│                      /   . .   \            ||:   |                                │
│                     .`._______.'.           ||: , |                                │
│                    /(           )\          ||:   |           ><^,>                │
│                  _/  \  \   /  /  \_        ||: . |                                │
│              _.~   `  \  \ /  /  '   ~.    _||_   |                                │
│     ____--`~ {     .~__\  V  /   .    -} -~    ~`---,              ___             │
│-~--~       _ _`.    \  |  |  | -/ '  .'_ _           ~~----_____-~'   `~----~~     │
│            >_       _} |  |  | {_       _<                                         │
│             /. - ~ ,_-'  .^.  `-_, ~ - .\                                          │
│                     '-'|/   \|`-`                                                  │
│                                                                                    │
│                                                                                    │
│                                                                                    │
└────────────────────────────────────────────────────────────────────────────────────┘
";

string room2 = @"
┌────────────────────────────────────────────────────────────────────────────────────┐
│                _│_                                                                 │
│               |(_)|                                     +                          │
│                |||                                    qoOop                        │
│                |||                                    (===)                        │
│                |||                                 '-.#####,                       │
│                |||                                  _;\;|\;:;,                     │
│                |||                                 ) __ ' \;::,                    │
│          ^     |^|     ^                       .--'  0   ':;;;:,           ;,      │
│        < ^ >   <+>   < ^ >                    (^           ;;::;          ;;;,     │
│         | |    |||    | |             _        --_.--.___,',:;::;     ,,,;:;;;,    │
│          \ \__/ | \__/ /             < \        `;     |  ;:;;:;        ':jgs;;,,  │
│            \,__.|.__,/             <`-; \__     ,;    /    ';:;;:,       ';;;'     │
│                (_)                 <`_   __',   ; ,  /    ::;;;:         //        │
│                                       `)|  \ \   ` .'      ';;:;,       //         │
│                                        `    \ `\  /        ;;:;;.      //__        │
│  @@@@  (___) _(_)_    @@@@  (___) _(_)_      \  `/`         ;:;  ~._,=~`   `~=,    │
│ @@()@@   Y  (_)@(_)  @@()@@   Y  (_)@(_)      \_|      (        ^     ^  ^ _^  \   │
│  @@@@   \|/   (_)\    @@@@   \|/   (_)\         \    _,`      / ^ ^  ^   .' `.^ ;  │
│  \|      |/      |    \|      |/      |<` .      '-;`       /`  ^   ^  /\    ) ^/  │
│   |/    \|      \|/    |/    \|      \|/'  \__..-'` ___,,,-'._ ^  ^ _.'\^`'-' ^/   │
│\\\|//  \\|//  \\\|//\\\|//  \\|//  \\\|// _   ..-''`          `~~~~`    `~===~`    │
│^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^_.-`-._\                                  │
└────────────────────────────────────────────────────────────────────────────────────┘
";

string room_cave1 = @"                                                                                  
┌────────────────────────────────────────────────────────────────────────────────────┐
│   ──  ───  ────     ─  ───   ───────         ──────    ─────     ──────      ───── │
│──────|───┐─      ─────  ┌──────|───┐ ──             ┌───────────|─┐─   ───       ─ │
│      |   └─┐─    ────  ┌┘      |   └┐  ────      ─┌─┘           | └─────┐─  ───┌───│
│      |     └───────────┘       |    └─┐         ┌─┘             |       └──────┘   │
│     @@@                        |      └┐  ────┌─┘              @@@                 │
│     @@@                       @@@      └┐─  ┌─┘                @@@                 │
│                               @@@       └───┘                                      │
│                                                                                    │
│                                                           ^^:^^                    │
│                                                          ___:____     |^\/^|       │
│                                                         '        `.    \  /        │
│                                                        |  O        \___/  |        │
├────────────────────────────────────────────────────────~~~~~~~~~~~~~~~~~~~~~~──────┤
│                                              _                                     │
│              mmm                     _      /_|       mmm                          │
│              )-(                    /_|    ('_)<|     )-(                          │
│             (   )                  ('_)<|   \_|      (   )                    /_|  │
│             |   |                   \_|              |   |                   ('_)<|│
│             |───|                                    |───|                    \_|  │
│             |___|     ┌─────────┐     ┌───────────┐  |___|              ┌───────┐  │
│┌───────────┐      ┌───┘ ──      └─────┘─    ───── └──────────┐     ┌────┘─  ─── └──│
│┘─   ────   └──────┘      ─      ───                     ──── └─────┘─         ─    │
└────────────────────────────────────────────────────────────────────────────────────┘
";

string cave_room2 = @"                                                                                   
┌────────────────────────────────────────────────────────────────────────────────────┐
├──|─┐ ────────────────  ──────────────────────────  ───────────────────  ───────────│
│  | └──────┐ ──── ┌─────┐  ────────────  ──────────  ────────────────────────────   │
│  |        └──────┘     └─|─────┐  ──────  ───────  ────── ──────────  ── ┌──────|──┤
│  |                       |     └─────┐ ────  ┌─|───┐  ──────────     ┌───┘      |  │
│ @@@                      |           └───────┘ |   └─────┐ ──────┌─|─┘          |  │
│ @@@                      |                     |         └───────┘ |           @@@ │
│                          |                    @@@                  |           @@@ │
│                          |                    @@@                  |               │
│                         @@@                                       @@@              │
│                         @@@                                       @@@              │
│                                                                                    │
├────────────────────────────────────────────────────────────────────────────────────┤
│                            O  o                                           _        │
│                       _\_   o                                            /_|       │
│             >('>   \\/  o\ .                           mmm       _      ('_)<|     │
│                    //\___=                             )-(      /_|      \_|       │
│     +  ~    +         ''     ++          ~            (   )    ('_)<|              │
│ +    ┌──────┐+    ~          +└┐┌+ ┌+         +    +  |   |     \_|             ~~ │
│  ┌───┘ ─────└───┐   +      +   └│──┘    +   ┌────┐    |   | ~         +     ~  + + │
├──┘  ──────────  │ + ┌──────┐    │    + ┌────┘ ── └───┐|___|   ┌──────────┐ +   ┌───┤
│──── ─────────── └───┘ ──── └────│──────┘ ─────────── └────────┘ ─────────└─────┘ ──│
│ ────────────────────────────────  ──────────────────────  ─────────────────────────│
└────────────────────────────────────────────────────────────────────────────────────┘
"; */

// variable naming: first number- my turn in alphbetical order of last name, second number-the number room
string room41 = @"
┌────────────────────────────────────────────────────────────────────────────────────┐
|──────────────────────────────── │               │ ──────────────────────────────   │
├─────────────┐ ─     ─── ┌──=────┘               └──────────┐      ──────────────── │
│       o  ~  │       ─── │  =  +                          ~ │           ─── ─────── │
│   >('>   ┌──┘   ─────── │__=8                      +      +│ ───       ─── ──      │
│          │ ───────────  │__\|,-                            │ ───────────── ──      │
│   #,#    │ ── ┌──────┐  │,-`=--.                           └─────────────┐ ──      │
│    #o#  +│ ── │      │  │ / |\                             _            +│ ───     │
├─────┐#   │ ─  │      └──┘   |                            ><_>            │ ───     │
│ ─── │ +  │ ─  │          ~ +                             ┌───────┐       │ ───     │
│ ─── │    │ ── │                                         ~│ ───── │       │ ─────── │
│     └────┘ ── │                                          │ ────  │    ┌──┘ ──────  │
│     ───────── │                             #o#   ~ ┌────┘ ───── │    │ ── ┌────┐  │
│     ────────  │                           ####o#   +│   ──────── │    │ ── │ + +│  │
│     ─── ┌─────┘   O  o                   #o# \#|_ ~ │ ────── ┌───┘    └────┘   +│  │
│     ─── │    _\_   o                    ###\─|/─────┤ ────── │                  │  │
│     ─── │ \\/  o\ .                     ┌#─{}{}{{───┘ ─── ┌──┘                  │  │
│     ─── │ //\___=                       │ ─────────────── │                 _\/_│  │
│         │~   ''                         │ ─────────       │_\/_            ~//o\│  │
│     ─── │                    ┌──────────┘ ───            ┌┘/o\\ _ +       ┌─┐ | │  │
│ ─────── │                    │        ───────       ──── │+'-|-,_┌────────┘ │'|'│  │
│ ──── ┌──┘                    | ──────────────       ──── └───────┘ ─────────└───┘  │
│ ──── │                       │       ───────────    ────────────────────────────── │
└────────────────────────────────────────────────────────────────────────────────────┘
";

string room42 = @"
┌────────────────────────────────────────────────────────────────────────────────────┐                                                                                        
│  ───────────────────────────────────────────────────────────────────────────────── │                                                                                        
│ ────────────      ┌───────────────┐    ─────────────────────────────────────────   │                                                                                        
│ ──────────────    │               └──────────────────────────────────────────────┐ │                                                                                        
│ ───    ┌────────=─┘                                                             +│ │                                                                                        
│   ──── │ +   ~  =~ +                                                             │ │                                                                                        
│ ─────  └──┐   __=8   +                                                           │ │                                                                                        
│ ────────  │   __\|,-~                                             __...-\/      .│ │                                                                                        
│ ┌─────────| + ,-`=--.         (v)                               ┌──.───.+        │ │                                                                                        
│ │ +      _|+_  / |\            =                                │ ──── │~        │ │                                                                                        
│ │    _   /o\\ +  |                      O  o                 _\/_  ─── │-..__..__│ │                                                                                        
│ │  ><_>   /\                             o                  ~//o\ ───  └────\/───┘ │                                                                                        
│ │                                       .           |          |│ ───────────────  │                                                                                        
│ │     ~                           ><^,>             |       ~ '|│   ─────────────  │                                                                                        
│ └─────────┐                                         |           │     ──────────── │                                                                                        
│ ───────── │ +          #o# ~                        |         + │  ──────────────  │                                                                                        
│ ───────── └─┐~       ####o#                         |           └────────────┐     │                                                                                        
│        ┌────┘       #o# \#|_~                      /X\          o            │ ──  │                                                                                        
│ ─────  │           ###\─|/─#                      //X\\     >('>             │     │                                                                                        
│   ──── │ +     _\/_┌#─{}{}{{                    ┌────────────────────────────┘ ─   │                                                                                        
│        │       //o\│     │ +                    │  ─────────────────────────────   │                                                                                        
│  ────  └───────────┘ ─── └──────┐               │ ─────────────────────────────    │                                                                                        
│ ─────────────────────────────   │               │  ─────────────────────────────── │                                                                                        
└─────────────────────────────────┴───────────────┴──────────────────────────────────┘                                                                                        
";
    //Console.WriteLine(room1);
    }
}
