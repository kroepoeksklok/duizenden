import React, { Component } from "react";
import PlayerApi from './../api/playerApi';

export class Game extends Component {
    constructor(props) {
        super(props);
        this.state = {
            newPlayerName: ''
        };
    }

    joinGame = (event) => {
        PlayerApi.join(this.state.newPlayerName);
        event.preventDefault();
    };

    updateInputValue = (evt) => {
        this.setState({newPlayerName: evt.target.value});
    };

    render() {
        return (
            <div>
                <div>Da game</div>
                <form onSubmit={this.joinGame}>
                    <label>
                        Name: 
                        <input type="text" value={this.state.newPlayerName} onChange={evt => this.updateInputValue(evt)} /><br />
                    </label>
                    <button onClick={this.joinGame}>Join!</button>
                </form>
            </div>
        );
    }
}