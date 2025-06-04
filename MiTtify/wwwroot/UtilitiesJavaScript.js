function playAudio(player, path){
    player.getElementsByTagName('source')[0].src = path;
    player.load();
    player.play();
}
function pauseAudio(player, path){
    player.getElementsByTagName('source')[0].src = path;
    player.pause()
}