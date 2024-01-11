let players = [
    { id: 1, name: '玩家A', level: 10 },
    { id: 2, name: '玩家B', level: 15 },
    { id: 3, name: '玩家C', level: 20 }
];

function addPlayer(player) {
    players.push(player);
}

function removePlayer(playerId) {
    players = players.filter(player => player.id !== playerId);
}

function findPlayer(playerId) {
    return players.find(player => player.id === playerId);
}

function updatePlayer(playerId, updatedAttributes) {
    const player = findPlayer(playerId);
    if (player) {
        Object.assign(player, updatedAttributes);
    }
}