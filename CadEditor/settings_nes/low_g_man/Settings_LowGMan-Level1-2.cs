using CadEditor;
using System;
//css_include shared_settings/BlockUtils.cs;
//css_include shared_settings/SharedUtils.cs;

public class Data 
{
  public OffsetRec[] getScreensOffsetsForLevels() {
    var ans = new OffsetRec[] {
      new OffsetRec(0x44f8, 2 , 16*15, 16, 15),
      new OffsetRec(0x46d8, 4 , 16*12, 16, 12),
      new OffsetRec(0x49d8, 1 , 16*21, 16, 21),
      new OffsetRec(0x4b28, 2 , 16*12, 16, 12),
      new OffsetRec(0x4ca8, 1 , 16*15, 16, 15),
      new OffsetRec(0x4d68, 1 , 16*15, 16, 15),
      new OffsetRec(0x4e58, 1 , 16*12, 16, 12),
    };
    return ans;  
  }
  
  public bool isBigBlockEditorEnabled() { return false; }
  public bool isBlockEditorEnabled()    { return true; }
  public bool isEnemyEditorEnabled()    { return false; }
  
  public GetVideoPageAddrFunc getVideoPageAddrFunc() { return SharedUtils.fakeVideoAddr(); }
  public GetVideoChunkFunc    getVideoChunkFunc()    { return SharedUtils.getVideoChunk("chr1-2.bin");   }
  public SetVideoChunkFunc    setVideoChunkFunc()    { return null; }
  
  public bool isBuildScreenFromSmallBlocks() { return true; }
  
  public OffsetRec getBlocksOffset()    { return new OffsetRec(0x4f68, 1  , 0x1000);  }
  public int getBlocksCount()           { return 160; }
  public int getBigBlocksCount()        { return 160; }
  public int getPalBytesAddr()          { return 0x51a8; }
  
  public GetBlocksFunc        getBlocksFunc() { return BlockUtils.getBlocksLinear2x2Masked;}
  public SetBlocksFunc        setBlocksFunc() { return BlockUtils.setBlocksLinear2x2Masked;}
  public GetPalFunc           getPalFunc()           { return SharedUtils.readPalFromBin("pal1-2.bin"); }
  public SetPalFunc           setPalFunc()           { return null;}
}