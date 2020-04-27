import axios from 'axios';
import * as constants from '../constants';

class PlayerApi {
    static join(playerName) {
        console.log('join called', constants.WEBAPI_ROOT_URL);
        const joinData = {
            "playerName": playerName
        };
        axios.post(`${constants.WEBAPI_ROOT_URL}/player`, joinData);
    }
}

export default PlayerApi;