//Entity.cs
using UnityEngine;
namespace Assignment03.StudentSolution
{
    public class Entity
    {
        public string name;
        private Vector3 position;
        protected int health;

        public virtual void Update() { }
        protected virtual void TakeDamage(int damage) { }
        private void Move(Vector3 direction) { }
    }
}
//Player.cs
namespace Assignment03.StudentSolution
{
    public class Player : Entity
    {
        public int score;
        private Item[] items;

        public void CollectItem(Item item) { }
        protected void LevelUp() { }
    }
}
//NPC.cs
namespace Assignment03.StudentSolution
{
    public class NPC : Entity
    {
        public string dialogue;
        private bool isFriendly;

        public virtual void Interact(Player player) { }
    }
}
//Enemy.cs
namespace Assignment03.StudentSolution
{
    public class Enemy : Entity
    {
        public int damage;
        protected int aiLevel;

        public virtual void Attack(Entity target) { }
        protected virtual void Patrol() { }
    }
}
//MeleeEnemy.cs
namespace Assignment03.StudentSolution
{
    public class MeleeEnemy : Enemy
    {
        public int strength;

        public override void Attack(Entity target) { }
    }
}
//RangeEnemy.cs
namespace Assignment03.StudentSolution
{
    public class RangeEnemy : Enemy
    {
        public int range;

        public override void Attack(Entity target) { }
    }
}
//Troll.cs
namespace Assignment03.StudentSolution
{
    public class Troll : MeleeEnemy
    {
        public int regenerationRate;

        public void Regenerate() { }
    }
}
//Orc.cs
namespace Assignment03.StudentSolution
{
    public class Orc : MeleeEnemy
    {
        public int rageLevel;

        public void Enrage() { }
    }
}
//Archer.cs
namespace Assignment03.StudentSolution
{
    public class Archer : RangeEnemy
    {
        public int accuracy;

        public override void Attack(Entity target) { }
        public void AimAndShoot(Entity target) { }
    }
}
//Mage.cs
namespace Assignment03.StudentSolution
{
    public class Mage : RangeEnemy
    {
        public int mana;

        public override void Attack(Entity target) { }
        public void CastSpell(Entity target) { }
    }
}
//Item.cs
namespace Assignment03.StudentSolution
{
    public class Item
    {
        public string name;
        private int value;

        public virtual void Use(Player player) { }
    }
}
//Potion.cs
namespace Assignment03.StudentSolution
{
    public class Potion : Item
    {
        public int healingAmount;

        public override void Use(Player player) { }
    }
}
//Equipment.cs
namespace Assignment03.StudentSolution
{
    public class Equipment : Item
    {
        public virtual void Equip(Player player) { }
    }
}
//Armor.cs
namespace Assignment03.StudentSolution
{
    public class Armor : Equipment
    {
        public int defense;

        public override void Equip(Player player) { }
    }
}
//Weapon.cs
namespace Assignment03.StudentSolution
{
    public class Weapon : Equipment
    {
        public int attackPower;

        public virtual void DealDamage(Entity target) { }
    }
}
//Sword.cs
namespace Assignment03.StudentSolution
{
    public class Sword : Weapon
    {
        public int bladeLength;

        public void Slash() { }
        public override void Equip(Player player) { }
        public override void DealDamage(Entity target) { }
    }
}
//Bow.cs
namespace Assignment03.StudentSolution
{
    public class Bow : Weapon
    {
        public int range;

        public void Shoot() { }
        public override void Equip(Player player) { }
        public override void DealDamage(Entity target) { }
    }
}
//Staff.cs
namespace Assignment03.StudentSolution
{
    public class Staff : Weapon
    {
        public int magicPower;

        public void CastSpell() { }
        public override void Equip(Player player) { }
        public override void DealDamage(Entity target) { }
    }
}