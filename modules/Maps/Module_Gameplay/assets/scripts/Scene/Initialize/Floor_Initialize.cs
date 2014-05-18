function Module_Gameplay::Floor_Initialize(%this)
{

ModuleDatabase.LoadExplicit("Module_Forest");

%this.Module_ID_Map_Background=Module_Forest;

%CompositeSprite_Floor=new CompositeSprite()
{

SceneLayer=30;
BodyType="static";

};

%CompositeSprite_Floor.SetBatchLayout("off");
%CompositeSprite_Floor.SetBatchSortMode("z");
%CompositeSprite_Floor.SetBatchIsolated(true);

%Vector_2D_World_Limits_Half_Offset=
%this.Vector_2D_World_Limits.X*0.5
SPC
%this.Vector_2D_World_Limits.Y*0.5;

for (%y=0;%y<%this.Vector_2D_World_Limits.Y;%y+=%this.Vector_2D_Floor_Tile_Size.Y)
{

for (%x=0;%x<%this.Vector_2D_World_Limits.X;%x+=%this.Vector_2D_Floor_Tile_Size.X)
{

%ScriptObject_String_Floor_Tile=Module_Forest.SimSet_String_Floor_Tiles.getObject(getRandom(0,Module_Forest.SimSet_String_Floor_Tiles.getCount()-1));

%Vector_2D_Position=
(%x-%Vector_2D_Grid_Half_Offset.X)+(%this.Vector_2D_Floor_Tile_Size.X*0.5)
SPC
(%y-%Vector_2D_Grid_Half_Offset.Y)+(%this.Vector_2D_Floor_Tile_Size.Y*0.5);

%CompositeSprite_Floor.addSprite();

%CompositeSprite_Floor.setSpriteLocalPosition(%Vector_2D_Position);

%CompositeSprite_Floor.setSpriteSize(%this.Vector_2D_Floor_Tile_Size);

%CompositeSprite_Floor.setSpriteImage(%ScriptObject_String_Floor_Tile.String_Name);

}

}

Scene_Carambola.add(%CompositeSprite_Floor);

Scene_Carambola.setGravity(0,-10);

}
