const axios = require('axios');

async function addPlayer(player) {
    try {
        const response = await axios.post('/api/players', player);
        return response.data;
    } catch (error) {
        console.error('添加玩家属性失败:', error);
        throw error;
    }
}

async function removePlayer(playerId) {
    try {
        const response = await axios.delete(`/api/players/${playerId}`);
        return response.data;
    } catch (error) {
        console.error('删除玩家属性失败:', error);
        throw error;
    }
}

async function getPlayer(playerId) {
    try {
        const response = await axios.get(`/api/players/${playerId}`);
        return response.data;
    } catch (error) {
        console.error('获取玩家属性失败:', error);
        throw error;
    }
}

async function updatePlayer(playerId, updatedAttributes) {
    try {
        const response = await axios.put(`/api/players/${playerId}`, updatedAttributes);
        return response.data;
    } catch (error) {
        console.error('更新玩家属性失败:', error);
        throw error;
    }
}
