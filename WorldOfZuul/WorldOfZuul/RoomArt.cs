using System.Collections.Generic;

namespace WorldOfZuul
{
    public class RoomArt
{
    public List<string> Rooms { get; private set; }

    public int RoomWidth { get; private set; } = 86;
    public int RoomHeight { get; private set; } = 24;
    public RoomArt()
    {
        Rooms = new List<string>();
        //Each room is 86x26 (actually 24 but there are 2 new lines at the start and end)

        AddRoomArt(@"
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
    ");

        AddRoomArt(@"
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
    ");

        AddRoomArt(@"                                                                                  
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
    ");

        AddRoomArt(@"                                                                                   
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
    │                         @@@             ,'--`.                    @@@              │
    │                                        / _  _ \                                    │
    │                                        |(@)(@)|                                    │
    │                                        )  __  (                           ─        │
    │                       _\_   o         /,'))((`.\                         /_|       │
    │             >('>   \\/  o\ .         (( ((  )) ))      hh        _      ('_)<|     │
    │                    //\___=            `\ `)(' /'       )-(      /_|      \_|       │
    │     +  ~    +         ''     ++          ~            (   )    ('_)<|              │
    │ +    ┌──────┐+    ~          +└┐┌+ ┌+         +    +  |   |     \_|             ~~ │
    │  ┌───┘ ─────└───┐   +      +   └│──┘    +   ┌────┐    |   | ~         +     ~  + + │
    ├──┘  ──────────  │ + ┌──────┐    │    + ┌────┘ ── └───┐|___|   ┌──────────┐ +   ┌───┤
    │──── ─────────── └───┘ ──── └────│──────┘ ─────────── └────────┘ ─────────└─────┘ ──│
    │ ────────────────────────────────  ──────────────────────  ─────────────────────────│
    └────────────────────────────────────────────────────────────────────────────────────┘
    ");

        AddRoomArt(@"
    ┌─────────────────────────────────┬───────────────┬──────────────────────────────────┐
    │       ───────────────────────── │               │ ──────────────────────────────   │
    ├─────────────┐ ─     ─── ┌──=────┘               └──────────┐      ──────────────── │
    │       o  ~  │       ─── │  =  +                          ~ │           ─── ─────── │
    │   >('>   ┌──┘   ─────── │__=8                      +      +│ ───       ─── ──      │
    │          │ ───────────  │__\|,-                            │ ───────────── ──      │
    │   #,#    │ ── ┌──────┐  │,-`=--.                           └─────────────┐ ──      │
    │    #o#  +│ ── │      │  │ / |\                                          +│ ───     │
    ├─────┐#   │ ─  │      └──┘   |                            ><_>            │ ───     │
    │ ─── │ +  │ ─  │          ~ +                             ┌───────┐       │ ───     │
    │ ─── │    │ ── │                                         ~│ ───── │       │ ─────── │
    │     └────┘ ── │                                          │ ────  │    ┌──┘ ──────  │
    │     ───────── │                             #o#   ~ ┌────┘ ───── │    │ ── ┌────┐  │
    │     ────────  │                   mmm     ####o#   +│   ──────── │    │ ── │ + +│  │
    │     ─── ┌─────┘   O  o            )-(    #o# \#|_ ~ │ ────── ┌───┘    └────┘   +│  │
    │     ─── │    _\_   o             (   )  ###\─|/─────┤ ────── │                  │  │
    │     ─── │ \\/  o\ .              |   |  ┌#─{}{}{{───┘ ─── ┌──┘                  │  │
    │     ─── │ //\___=                |   |  │ ─────────────── │                 _\/_│  │
    │         │~   ''                  |___|  │ ─────────       │_\/_            ~//o\│  │
    │     ─── │                    ┌──────────┘ ───            ┌┘/o\\ _ +       ┌─┐ | │  │
    │ ─────── │                    │        ───────       ──── │+'-|-,_┌────────┘ │'|'│  │
    │ ──── ┌──┘                    │ ──────────────       ──── └───────┘ ─────────└───┘  │
    │ ──── │                       │       ───────────    ────────────────────────────── │
    └──────┴───────────────────────┴─────────────────────────────────────────────────────┘
    ");
     AddRoomArt(@"
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
    │        ┌────┘       #o# \#|v~                      /X\          o            │ ──  │
    │ ─────  │           ###\─|/─#                      //X\\     >('>             │     │
    │   ──── │ +     _\/_┌#─{}{}{{                    ┌────────────────────────────┘ ─   │
    │        │       //o\│     │ +                    │  ─────────────────────────────   │
    │  ────  └───────────┘ ─── └──────┐               │ ─────────────────────────────    │
    │ ─────────────────────────────   │               │  ─────────────────────────────── │
    └─────────────────────────────────┴───────────────┴──────────────────────────────────┘
     ");
        AddRoomArt(@"
    ┌────────────────────────────────────────────────────────────────────────────────────┐ 
    │                                                                  O                 │ 
    │                                                                 O                  │ 
    │                                                                  o  \``/           │ 
    │       ___________                                                   /o `))         │ 
    │      /=//==//=/  \                 .     '     ,                   /_/\_ss))       │ 
    │     |=||==||=|    |                  _________                         |_ss))/|    │ 
    │     |=||==||=|~-, |               _ /_|_____|_\ _                     |__ss))_|    │ 
    │     |=||==||=|^.`;|                 '. \   / .'                      |__sss))_|    │ 
    │ jgs  \=\\==\\=\`=.:                   '.\ /.'                        |___ss))\|    │ 
    │       `-------`^-,`.                    '.'                           |_ss))       │ 
    │────────────\~  `.~,'                                                   )_s))       │ 
    │            ─\ ',~^:,                                             (`(  /_s))        │ 
    │             ─\~.^;`.                                              (_\/_s))         │ 
    │               └\-.~=;.                                             (\/))           │ 
    │                ─└\`.^.:`.        --------                   -----                  │ 
    │                  ───────\      ---      ----      -       ---    ---     ---       │ 
    │                          ─\                 -------                ------          │ 
    │                                                                                    │ 
    │        -------                                                                     │ 
    │      ---      -----                   ----------        --                         │ 
    │                   ----                         ---------                           │ 
    │                                                                                    │ 
    └────────────────────────────────────────────────────────────────────────────────────┘ 
    ");
        AddRoomArt(@"
    ┌────────────────────────────────────────────────────────────────────────────────────┐  
    │                                                                                    │  
    │                                                                                    │  
    │                                                                                    │  
    │                                                                                    │  
    │                                                                                    │  
    │                    .                                                               │  
    │                   /=\\                                                             │  
    │                  /===\ \                                                           │  
    │                 /=====\' \                                                         │  
    │                /=======\'' \                                                       │  
    │               /=========\ ' '\                                                     │  
    │              /===========\''   \                                                   │  
    │      ~~~~~~ /=============\ ' '  \                                                 │  
    │    ~~~    ~/===============\   ''  \  ~~~~~~~~~~          ~        .<==+.  ~~      │  
    │           /=================\' ' ' ' \~         ~~~~~~~~~~ ~~~          \\  ~~~~~  │  
    │          /===================\' ' '  ' \                   __  /*-----._//         │  
    │~~       /=====================\' '   ' ' \                 >_)='-[[[[---'          │  
    │  ~ ~~~ /=======================\  '   ' /           ~~~~~                          │  
    │       /=========================\   ' /                                ~~~~        │  
    │      /===========================\'  /                     ~~~    ~~~~~~  ~~~~ ~~  │  
    │     /=============================\/~~~~      ~~~~~~~    ~~   ~~~                  │  
    │                                        ~~~~~~~                  ~~~~~~             │  
    └────────────────────────────────────────────────────────────────────────────────────┘  
    ");
        AddRoomArt(@"
    -----------------------------------------------------------------------------------------
    |                 \                      /                          \                   |
    |                  \                    /                            \                  |
    |                   \                  /                              \                 |
    |                    \     ______     /                                \               _|
    |                     \   /      \   /                 ______          \             /  |
    |                      \ /        \ /                 /      \          \___________/   |
    |                      /|          |                 /        \                         |
    |     ><(((º>        /  |          |     ><(((º>    /          \                        |
    |   (is that a      /   |          |               /            \                       |
    |   plastic bag?)  |    |          |              /              \                      |
    |                  |    |          |             /                \                     |
    |    ------------  |----|----------|-----------/--------------------\-------/~~~~~\     |
    |   /              |    |          |          /                      \     /       \    |
    |  /               |    |          |         /                        \   /         \   |
    | /                |    |          |        /                          \ /           \  |
    |/_________________|____|__________|_______/___________________________/--------------  |
    |                    ~~~~~~           ~~~~             ~~~~~~~~                         |
    |                 ~~~~~~~~~~~~      ~~~~~~~~        ~~~~~~~~~~~~~~~~                    |
    |                   ~~~~             ~~~~~~           ~~~~~~~~                          |
    |                             |      |                                                  |
    |                            /|      |\                                                 |
    |                           / |      | \                                                |
    |                          /  |______|  \                                               |
    -----------------------------------------------------------------------------------------
    ");
        AddRoomArt(@"
    -----------------------------------------------------------------------------------------
    |           \                     /                             \                       |
    |           \                   /                               \                       |
    |            \                 /                                 \                      |
    |             \               /                                   \                    _|
    |              \             /                   _____            \                  /  |
                    \___________/                  /       \           \_______________/    |
                    |                              /         \                              |
                    |                             /           \                             |
                    |              ><(((º>      /             \     ><(((º>                 |
                    |             (is that a   /               \                            |
                    |             chemical    /                 \        ><(((º>            |
    |               |             vial?)     /                   \                          |
    |               |    ------------------/---------------------\----------------/~~~~~\   |
    |               |   /                 /                       \              /       \  |
    |               |  /                 /                         \            /         \ |
    |               | /                 /                           \          /           \|
    |               |/                 /_____________________________\--------/-------------\
    |               |                                                      _________        |
    |               |                                                     |---------|       |
    |               |                    ~                                |         |       |
    |               |                    ~                                |         |       |
    |               |                  ~~~                                |         |       |
    |               |                 ~~~~~                               |_________|       |
    -----------------------------------------------------------------------------------------
    ");
    }

    public void AddRoomArt(string roomArt)
    {
        Rooms.Add(roomArt);
    }
}
}
