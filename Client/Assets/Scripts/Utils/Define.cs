/******
공동 작성
작성일 : 23.03.31

최근 수정 일자 : 23.10.02
최근 수정 내용 : 로그인 상태 추가
 ******/

namespace Client
{
    public class Define
    {

        public enum LoginState
        {
            //로그인 서버로 패킷 보내지 않은 상태
            CleanLogin,
            //로그인 서버로 패킷 보내고 대기 상태
            SendLogin,
            MaxCount
        }

        public enum Charcter
        {
            Warrior,
            Rifleman,
            Wizard,
            Priest,
            MaxCount
        }

        public enum Sound
        {
            BGM,
            SFX,
            MaxCount
        }
        public enum BGM
        {



            MaxCount
        }
        public enum SFX
        {
            WarriorAttack,
            RiflemanAttack,
            WizzardAttack,
            PriestAttack,
            PriestSkill,
            MaxCount
        }
        public enum State
        {
            Idle,
            Play,
            Defeat,
            Win,
            MaxCount
        }

        /// <summary> 아이템 종류 </summary>
        public enum ItemKind
        {
            Damage,
            Range,
            Cooldown,
            Weight,
            Speed,
            MaxCount
        }

        /// <summary> 아이템 등급 </summary>
        public enum ItemRank
        {
            Normal,
            Rare,
            Unique,
            Epic,
            Legendary
        }

        public enum Tag
        {
            Monster,
            Tower,
            MaxCount
        }

        /// <summary>
        /// UI Event 종류 지정
        /// </summary>
        public enum UIEvent
        {
            Click,
            Drag,
            DragEnd,
        }

        public enum Scenes
        { 
            Login,
            Title,
            Lobby,
            Game,
        }

        public enum MonsterName
        {
            _0BlackBoar,
            _1Bat,
            _2CaveRat,
            _3Crawler,
            _4Porcupine,
            _5CrystalLizard,
            _6Scarab,
            _7ShardLizard,
            _8DreadEye,
            BlackWolf,

            _0BlackBoar1,
            _1Bat1,
            _2CaveRat1,
            _3Crawler1,
            _4Porcupine1,
            _5CrystalLizard1,
            _6Scarab1,
            _7ShardLizard1,
            _8DreadEye1,                                
            BlackBear,

            _0BlackBoar2,
            _1Bat2,
            _2CaveRat2,
            _3Crawler2,
            _4Porcupine2,
            _5CrystalLizard2,
            _6Scarab2,
            _7ShardLizard2,
            _8DreadEye2,
            MinerBoar,

            _0BlackBoar3,
            _1Bat3,
            _2CaveRat3,
            _3Crawler3,
            _4Porcupine3,
            _5CrystalLizard3,
            _6Scarab3,
            _7ShardLizard3,
            _8DreadEye3,
            Cerberus,

            _0BlackBoar4,
            _1Bat4,
            _2CaveRat4,
            _3Crawler4,
            _4Porcupine4,
            _5CrystalLizard4,
            _6Scarab4,
            _7ShardLizard4,
            _8DreadEye4,
            SlugQueen,

            _0BlackBoar5,
            _1Bat5,
            _2CaveRat5,
            _3Crawler5,
            _4Porcupine5,
            _5CrystalLizard5,
            _6Scarab5,
            _7ShardLizard5,
            _8DreadEye5,
            Nightmare,

            MaxCount
        }

        //PurpleScarab,
        //SlugQueen,
        //Warg,
        public enum MonsterState
        {
            Idle,
            Attack,
            Run,
            Walk,
            Death,
            MaxCount
        }

        
    }
}