function ifLast(a, b){ 
    if(a - b > 1) return ','; else return '';
} 
function isPlayerMoving(){ 
    if(typeof(ArmadaBattle.Game.myPlayer.currentMove)===undefined) return !1; 
    return (ArmadaBattle.Game.myPlayer.currentMove===null ? !0 : (ArmadaBattle.Game.myPlayer.currentMove.currentPathGoIndex != ArmadaBattle.Game.myPlayer.currentMove.goPositionPath.x.length));
}
function getMyPlayer(){
    g = ArmadaBattle.Game.myPlayer;
    return {
        Hp: g.options.HP,
        MaxHp: g.options.maxHP,
        X: g.GUI.group.x,
        Y: g.GUI.group.Y,
        Shooting: (g.currentShoot!=null ? g.currentShoot.shooted.id : null),
        Repairing: g.currentRepair!=null,
        Moving: isPlayerMoving()
    };
}

(function() { var button = $('#duplicateTabs > .modal-dialog > .modal-content > .modal-footer > button'); if($('#duplicateTabs').css('display')=='block') button.click(); })();