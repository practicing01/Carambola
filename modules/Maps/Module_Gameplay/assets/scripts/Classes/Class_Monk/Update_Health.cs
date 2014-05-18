function Class_Monk::Update_Health(%this,%Int_Amount,%Char_Operation)
{

if (%Char_Operation==0)
{

%this.Int_Health=%Int_Amount;

}
else if (%Char_Operation==1)
{

%this.Int_Health+=%Int_Amount;

if (%this.Int_Health>100)
{

%this.Int_Health=100;

}

}
else if (%Char_Operation==-1)
{

%this.Int_Health-=%Int_Amount;

}

if (%this.Int_Health<=0)
{

%Sprite_Explosion=new Sprite()
{

Position=%this.Position;
Size=Module_Gameplay.Vector_2D_Explosion_Size;
Animation="Module_Gameplay:Animation_Explosion";
class="Class_Explosion";
SceneLayer=14;

Module_ID_Parent=Module_Gameplay;

};

Scene_Carambola.add(%Sprite_Explosion);

//Spawn random static tower.

%String_Casting_Tower_Type_Previous=%this.Module_ID_Parent.Module_ID_Map_Background.String_Casting_Tower_Type;

%this.Module_ID_Parent.Module_ID_Map_Background.String_Casting_Tower_Type="Static";

%this.Module_ID_Parent.Module_ID_Map_Background.Cast_Towers(%this.Position);

%this.Module_ID_Parent.Module_ID_Map_Background.String_Casting_Tower_Type=%String_Casting_Tower_Type_Previous;

%this.safeDelete();

}

}
